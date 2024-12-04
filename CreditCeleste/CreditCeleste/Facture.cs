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

        public Facture (DateTime aaaammjj,string type,double montant)
        {
            dateFacture = aaaammjj;
            typeFrais = type;
            montantF = montant;
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
    }
}
