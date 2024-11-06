using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Concession
    {
     // attribut de l'objet
        private string monNomConcession;
        private string adresseConc;
        private List<Vendeur> lesVendeurs = new List<Vendeur>();
        public Concession(string nomConcession, string adresseConcession)
        {
            monNomConcession = nomConcession;
            adresseConc = adresseConcession;
        }
        public  List<Vendeur> getLesVendeurs()
        {
            return lesVendeurs;
        }
        public void ajoutVendeur(Vendeur unVendeur)
        {
           lesVendeurs.Add(unVendeur); 
        }
         // liste fortement typée
    }
}
