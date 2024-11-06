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
        public static Voiture uneVoiture;
        public static Client unClient;
        public static frmAccueil frmAccueil;
        public static frmIntroduction fenIntroduction;
        public static frmVoiture fenVoiture;
        public static List<Credit> lesCrdits;
        public static Credit unCredit;
        public static frmCalculCredit fenCalcul;




    }
}
