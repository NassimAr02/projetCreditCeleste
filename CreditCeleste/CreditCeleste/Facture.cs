using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Facture
    {
        private string dateFacture ;
        private string typeFrais;
        private double montantF;

        public Facture (string aaaammjj,string type,double montant)
        {
            dateFacture = aaaammjj;
            typeFrais = type;
            montantF = montant;
        }

        public void setDateFacture(string aaaammjj)
        {
            dateFacture = aaaammjj;

        }
        public string getDataFacture()
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
