using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Vendeur
    {
        private string civilite;
        private string nom;
        private string prenom;
        public Vendeur(string civ, string nomV,string prenomV)
        {
            civilite = civ;
            nom = nomV;
            prenom = prenomV;

        }

        public string getInfoVendeur()
        {
            return civilite + " " + nom + " " + prenom;
        }
        
    }
}
