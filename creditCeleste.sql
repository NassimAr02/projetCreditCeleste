-- Utiliser la base de données
USE creditCelesteARRASS;
GO

-- Supprimer les tables si elles existent
IF OBJECT_ID('Credit', 'U') IS NOT NULL DROP TABLE Credit;
IF OBJECT_ID('Client', 'U') IS NOT NULL DROP TABLE Client;
IF OBJECT_ID('Lier', 'U') IS NOT NULL DROP TABLE Lier;
IF OBJECT_ID('Voiture', 'U') IS NOT NULL DROP TABLE Voiture;
IF OBJECT_ID('NouvelleVoiture', 'U') IS NOT NULL DROP TABLE NouvelleVoiture;
IF OBJECT_ID('AncienneVoiture', 'U') IS NOT NULL DROP TABLE AncienneVoiture;
IF OBJECT_ID('Concession', 'U') IS NOT NULL DROP TABLE Concession;
IF OBJECT_ID('Visite', 'U') IS NOT NULL DROP TABLE Visite;
IF OBJECT_ID('Facture', 'U') IS NOT NULL DROP TABLE Facture;
IF OBJECT_ID('Remboursement', 'U') IS NOT NULL DROP TABLE Remboursement;
IF OBJECT_ID('Rembourser', 'U') IS NOT NULL DROP TABLE Rembourser;
IF OBJECT_ID('Users','U') IS NOT NULL DROP TABLE Users;

-- Table Client
CREATE TABLE Client (
   numeroClient INT IDENTITY(1,1) PRIMARY KEY,
   nomClient NVARCHAR(50),
   prenomClient NVARCHAR(50),
   adresseClient NVARCHAR(80),
   civilite NVARCHAR(3)
);
-- Table Credit
CREATE TABLE Credit (
   numeroSouscription INT IDENTITY(1,1) PRIMARY KEY,
   montant DECIMAL(10,2),
   duree INT,
   taux DECIMAL(5,3),
   mensualite DECIMAL(10,2),
   dateSaisie DATETIME DEFAULT GETDATE(),
   numeroClient INT NOT NULL,
   FOREIGN KEY (numeroClient) REFERENCES Client(numeroClient)
);

-- Table Concession
CREATE TABLE Concession (
   numeroConcession INT IDENTITY(1,1) PRIMARY KEY,
   nomConcession NVARCHAR(50),
   numRueConcession NVARCHAR(8),
   nomRueConcession NVARCHAR(80),
   codePostalConcession NVARCHAR(5),
   villeConcession NVARCHAR(50)
)
INSERT INTO Concession(nomConcession,numRueConcession,nomRueConcession,codePostalConcession,villeConcession)VALUES('Concession Celeste','12','Rue du corps Armée','67000','Strasbourg');

-- Table Voiture
CREATE TABLE Voiture (
   numeroConcession INT,
   numeroImmat CHAR(9),
   dateImmat DATE,
   numeroSerie NVARCHAR(50),
   PRIMARY KEY (numeroConcession, numeroImmat),
   FOREIGN KEY (numeroConcession) REFERENCES Concession(numeroConcession)
);
-- Table AncienneVoiture
CREATE TABLE AncienneVoiture (
   numeroConcession INT,
   numeroImmat CHAR(9),
   ancienneVoiture NVARCHAR(50),
   PRIMARY KEY (numeroConcession, numeroImmat),
   FOREIGN KEY (numeroConcession, numeroImmat) REFERENCES Voiture(numeroConcession, numeroImmat)
);
-- Table NouvelleVoiture
CREATE TABLE NouvelleVoiture (
   numeroConcession INT IDENTITY(1,1),
   numeroImmat CHAR(9),
   nouvelleVoiture NVARCHAR(50),
   puissance INT,
   age NVARCHAR(50),
   PRIMARY KEY (numeroConcession, numeroImmat),
   FOREIGN KEY (numeroConcession, numeroImmat) REFERENCES Voiture(numeroConcession, numeroImmat)
);

-- Table Lier
CREATE TABLE Lier (
   numeroClient INT,
   numeroConcession INT,
   numeroImmat CHAR(9),
   PRIMARY KEY (numeroClient, numeroConcession, numeroImmat),
   FOREIGN KEY (numeroClient) REFERENCES Client(numeroClient),
   FOREIGN KEY (numeroConcession, numeroImmat) REFERENCES Voiture(numeroConcession, numeroImmat)
);



CREATE TABLE Users (
    idUser INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) UNIQUE NOT NULL,
    passwordHash NVARCHAR(32) NOT NULL, -- MD5 produit une chaîne de 32 caractères hexadécimaux
    roleConcession NVARCHAR(20) NOT NULL, -- 'Visiteur', 'Vendeur', 'Comptabilité'
    nomCollaborateur NVARCHAR(50),
    prenomCollaborateur NVARCHAR(50),
    civiliteCollaborateur NVARCHAR(4),
    numeroConcession INT, -- Optionnel : liaison avec une concession
    FOREIGN KEY (numeroConcession) REFERENCES Concession(numeroConcession)
);
-- Table Visite
CREATE TABLE Visite (
   numVisite INT IDENTITY(1,1) PRIMARY KEY,
   datedepart DATE,
   dateRetour DATE,
   voiturePerso BIT,
   numeroConcession INT NOT NULL,
   idUser INT NOT NULL,
   FOREIGN KEY(numeroConcession) REFERENCES Concession(numeroConcession),
   FOREIGN KEY(idUser) REFERENCES Users(idUser)
);

-- Table Visiteur
CREATE TABLE Facture (
   numFacture INT IDENTITY(1,1) NOT NULL,
   dateFacture DATE,
   typeFrais NVARCHAR(50),
   montant DECIMAL(10,2),
   numVisite INT,
   PRIMARY KEY (numFacture),
   FOREIGN KEY (numVisite) REFERENCES Visite(numVisite)
);

-- Table Remboursement
CREATE TABLE Remboursement (
   numFacture INT,
   numRemboursement INT IDENTITY(1,1) NOT NULL,
   RAC DECIMAL(10,2),
   commentaire NVARCHAR(100)
   PRIMARY KEY (numRemboursement), 
   FOREIGN KEY (numFacture) REFERENCES Facture(numFacture)
);

CREATE TABLE Rembourser(
   numRemboursement INT,
   numFacture INT,
   PRIMARY KEY(numRemboursement, numFacture),
   FOREIGN KEY(numRemboursement) REFERENCES Remboursement(numRemboursement),
   FOREIGN KEY(numFacture) REFERENCES Facture(numFacture)
);

INSERT INTO Users (username, passwordHash, roleConcession, numeroConcession)
VALUES 
('visiteur1', LOWER(CONVERT(VARCHAR(32), HASHBYTES('MD5', 'passwordVisiteur1'), 2)), 'Visiteur', 1),
('vendeur1', LOWER(CONVERT(VARCHAR(32), HASHBYTES('MD5', 'passwordVendeur1'), 2)), 'Vendeur', 1),
('comptabilite1', LOWER(CONVERT(VARCHAR(32), HASHBYTES('MD5', 'passwordCompta1'), 2)), 'Comptabilité', 1);


IF OBJECT_ID('InsCredit', 'P') IS NOT NULL
    DROP PROCEDURE InsCredit;
GO

CREATE PROCEDURE InsCredit
    @MontantFin decimal(10,2),
    @nbMens int,
    @MontantMens decimal(10,2),
    @TauxAn decimal(5,3)
AS
BEGIN
    -- Valider les paramètres
    IF @MontantFin < 60000
    BEGIN
        -- Insertion des données dans la table CREDIT
        INSERT INTO [dbo].[CREDIT]
            (montant, duree, mensualite, taux)
        VALUES 
            (@MontantFin, @nbMens, @MontantMens, @TauxAn);
        
        RETURN 0; -- Succès
    END
    ELSE
    BEGIN
        -- Générer une erreur si les conditions ne sont pas respectées
        RAISERROR('Le montant à financer ne doit pas dépasser 60 000 EUROS', 16, 1);
        RETURN 1; -- Erreur
    END
END
GO

IF OBJECT_ID('SelUserId', 'P') IS NOT NULL
    DROP PROCEDURE SelUserId;
GO

CREATE PROCEDURE SelUserId
   @userN NVARCHAR(50),
   @passwordH NVARCHAR(32),
   @roleC NVARCHAR(20) OUTPUT
AS
BEGIN
   -- Initialiser la valeur de sortie à NULL par défaut
   SET @roleC = NULL;

   -- Vérifie si l'utilisateur existe avec les identifiants fournis
   IF EXISTS (
       SELECT 1 
       FROM [dbo].[Users] 
       WHERE username = @userN AND passwordHash = @passwordH
   )
   BEGIN
       -- Récupère le rôle de l'utilisateur
       SELECT @roleC = roleConcession
       FROM [dbo].[Users]
       WHERE username = @userN AND passwordHash = @passwordH;
   END
   ELSE
   BEGIN
       -- Lever une erreur si les identifiants sont incorrects
       RAISERROR('Nom d''utilisateur ou mot de passe incorrect', 16, 1);
   END
END
GO

IF OBJECT_ID('InsClient', 'P') IS NOT NULL 
    DROP PROCEDURE InsClient;
GO

CREATE PROCEDURE InsClient
   @civilite NVARCHAR(3),
   @nom NVARCHAR(50),
   @prenom NVARCHAR(50),
   @adresseClient NVARCHAR(80)
AS
BEGIN
   INSERT INTO [dbo].[Client]
      (civiliteClient, nomClient, prenomClient, adresseClient)
   VALUES
      (@civilite, @nom, @prenom, @adresseClient);
   
   RETURN 0;
END
GO

