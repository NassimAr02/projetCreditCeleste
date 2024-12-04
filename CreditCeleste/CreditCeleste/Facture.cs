using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Facture
    {

        private DateTime dateFacture ;
        private string typeFrais;
        private double montantF;
        private int numeroVisite;
        public Facture (DateTime aaaammjj,string type,double montant, int numVisite)
        {
            dateFacture = aaaammjj;
            typeFrais = type;
            montantF = montant;
            numeroVisite = numVisite;

        }

        public void setDateFacture(DateTime aaaammjj)
        {
            dateFacture = aaaammjj;

        }
        public DateTime getDateFacture()

        {
            return dateFacture;
        }
        public void setTypeFrais(string type)
        {
            typeFrais = type;
        }
        public string getTypeFrais()
        {
            return typeFrais;
        }
        public void setMontantF(double montant)
        {
            montantF = montant;
        }

        public double getMontantF()
        {
            return montantF;
        }
        public void setNumVisite(int numVisite)
        {
            numeroVisite = numVisite;
        }
        public int getNumVisite()
        {
            return numeroVisite;
        }


    }
}
