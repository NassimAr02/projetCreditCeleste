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
        private int numConcession { get; set; }
        private string monNomConcession { get; set; }
        private string numRueConcession { get; set; }
        private string nomRueConcession { get; set; }
        private string cpConcession { get; set; }
        private string villeConcession { get; set; }

        private List<Vendeur> lesVendeurs = new List<Vendeur>();
        public Concession(int numConcession,string nomConcession, string numRueConcession, string nomRueConcession, string cpConcession, string villeConcession)
        {
            this.numConcession = numConcession;
            monNomConcession = nomConcession;
            this.numRueConcession = numRueConcession;
            this.nomRueConcession = nomRueConcession;
            this.cpConcession = cpConcession;
            this.villeConcession = villeConcession;
        }
        public  List<Vendeur> getLesVendeurs()
        {
            return lesVendeurs;
        }
        public void ajoutVendeur(Vendeur unVendeur)
        {
           lesVendeurs.Add(unVendeur); 
        }
        public int NumConcession
        {
            get { return numConcession; }
            set { numConcession = value; }
        }
        public string MonNomConcession
        {
            get { return monNomConcession; }
            set { monNomConcession = value;  }
        }
        public string NumRueConcession
        {
            get { return numRueConcession; }
            set { numRueConcession = value; }
        }
        public string NomRueConcession
        {
            get { return nomRueConcession; }
            set { nomRueConcession = value; }
        }
        public string CpConcession
        {
            get { return cpConcession; }
            set { cpConcession = value; }
        }
        public string VilleConcession
        {
            get { return villeConcession; }
            set { villeConcession = value; }
        }
         // liste fortement typée
    }
}
