-- Utiliser la base de données
USE creditCelesteARRASS;
GO

-- Supprimer les tables si elles existent
IF OBJECT_ID('Financer', 'U') IS NOT NULL DROP TABLE Financer;
IF OBJECT_ID('Lier', 'U') IS NOT NULL DROP TABLE Lier;
IF OBJECT_ID('Vendeur', 'U') IS NOT NULL DROP TABLE Vendeur;
IF OBJECT_ID('Credit', 'U') IS NOT NULL DROP TABLE Credit;
IF OBJECT_ID('Visite', 'U') IS NOT NULL DROP TABLE Visite;
IF OBJECT_ID('Visiteur', 'U') IS NOT NULL DROP TABLE Visiteur;
IF OBJECT_ID('Collaborateur', 'U') IS NOT NULL DROP TABLE Collaborateur;
IF OBJECT_ID('NouvelleVoiture', 'U') IS NOT NULL DROP TABLE NouvelleVoiture;
IF OBJECT_ID('AncienneVoiture', 'U') IS NOT NULL DROP TABLE AncienneVoiture;
IF OBJECT_ID('Voiture', 'U') IS NOT NULL DROP TABLE Voiture;
IF OBJECT_ID('Client', 'U') IS NOT NULL DROP TABLE Client;
IF OBJECT_ID('Concession', 'U') IS NOT NULL DROP TABLE Concession;

-- Recréer les tables

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

-- Table Client
CREATE TABLE Client (
   numeroClient INT IDENTITY(1,1) PRIMARY KEY,
   nomClient NVARCHAR(50),
   prenomClient NVARCHAR(50),
   adresseClient NVARCHAR(80),
   civilite NVARCHAR(2)
);

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
   numeroConcession INT,
   numeroImmat CHAR(9),
   nouvelleVoiture NVARCHAR(50),
   puissance INT,
   age NVARCHAR(50),
   PRIMARY KEY (numeroConcession, numeroImmat),
   FOREIGN KEY (numeroConcession, numeroImmat) REFERENCES Voiture(numeroConcession, numeroImmat)
);

-- Table Collaborateur
CREATE TABLE Collaborateur (
   numeroConcession INT,
   numeroCollaborateur INT IDENTITY(1,1),
   nomCollaborateur NVARCHAR(50),
   prenomCollaborateur NVARCHAR(50),
   civiliteCollaborateur NVARCHAR(50),
   PRIMARY KEY (numeroConcession, numeroCollaborateur),
   FOREIGN KEY (numeroConcession) REFERENCES Concession(numeroConcession)
);

-- Table Visiteur
CREATE TABLE Visiteur (
   numeroConcession INT,
   numeroCollaborateur INT,
   fraisRepas DECIMAL(10,2),
   fraisHotel DECIMAL(10,2),
   fraisEssence DECIMAL(10,2),
   dateDepart DATE,
   dateRetour DATE,
   voiturePerso BIT,
   PRIMARY KEY (numeroConcession, numeroCollaborateur),
   FOREIGN KEY (numeroConcession, numeroCollaborateur) REFERENCES Collaborateur(numeroConcession, numeroCollaborateur)
);

-- Table Visite
CREATE TABLE Visite (
   numVisite INT IDENTITY(1,1) PRIMARY KEY,
   dateVisite DATE,
   numeroConcession INT NOT NULL,
   FOREIGN KEY (numeroConcession) REFERENCES Concession(numeroConcession)
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

-- Table Vendeur
CREATE TABLE Vendeur (
   numeroConcession INT,
   numeroCollaborateur INT,
   PRIMARY KEY (numeroConcession, numeroCollaborateur),
   FOREIGN KEY (numeroConcession, numeroCollaborateur) REFERENCES Collaborateur(numeroConcession, numeroCollaborateur)
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

-- Table Financer
CREATE TABLE Financer (
   numeroConcession INT,
   numeroCollaborateur INT,
   numVisite INT,
   maxRepas DECIMAL(10,2),
   maxHotel DECIMAL(10,2),
   maxEssence DECIMAL(10,2),
   prisEnCharge BIT,
   RAC DECIMAL(10,2),
   PRIMARY KEY (numeroConcession, numeroCollaborateur, numVisite),
   FOREIGN KEY (numeroConcession, numeroCollaborateur) REFERENCES Visiteur(numeroConcession, numeroCollaborateur),
   FOREIGN KEY (numVisite) REFERENCES Visite(numVisite)
);
CREATE TABLE Users (
    idUser INT IDENTITY(1,1) PRIMARY KEY,
    username NVARCHAR(50) UNIQUE NOT NULL,
    passwordHash NVARCHAR(32) NOT NULL, -- MD5 produit une chaîne de 32 caractères hexadécimaux
    roleConcession NVARCHAR(20) NOT NULL, -- 'Visiteur', 'Vendeur', 'Comptabilité'
    numeroConcession INT, -- Optionnel : liaison avec une concession
    FOREIGN KEY (numeroConcession) REFERENCES Concession(numeroConcession)
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

