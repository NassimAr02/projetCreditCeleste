using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreditCeleste
{
    static class Globales // pas la peine de l'instancier // pas besoin de faire de new
    { //comparable à des variables session en PHP
        public static string nomUtilisateur = "ARRASS"; // attribut de classe
        public static string maRegion = "Alsace";
        
        // Les informations de la concession : une concession
        public static Concession uneConcession; // = new Concession();

        public static AncienneVoiture uneAncienneVoiture;
        public static NouvelleVoiture uneNouvelleVoiture;
        public static Client unClient;
        public static frmConnexion fenConnexion;
        public static frmAccueil fenAccueil;
        public static frmIntroduction fenIntroduction;
        public static frmVoiture fenVoiture;
        public static List<Credit> lesCredits;
        public static Credit unCredit;
        public static frmCalculCredit fenCalcul;
        public static frmListeCredit fenListeCredit;
        public static frmComptabilite fenComptabilite;
        public static frmVisiteur fenVisiteur;
        public static Facture facture1;
        public static Facture facture2;
        public static Facture facture3;
        public static Visite uneVisite;
        public static frmAjoutClient fenAjoutClient;
        


    }
}
