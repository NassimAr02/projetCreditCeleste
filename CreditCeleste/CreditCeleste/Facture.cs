using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Facture
    {
<<<<<<< HEAD
        private DateTime dateFacture ;
        private string typeFrais;
        private double montantF;

        public Facture (DateTime aaaammjj,string type,double montant)
=======
        private string dateFacture ;
        private string typeFrais;
        private double montantF;

        public Facture (string aaaammjj,string type,double montant)
>>>>>>> bc1f2fb5608bb77cfd02fc21ab51eae0d62f9c0c
        {
            dateFacture = aaaammjj;
            typeFrais = type;
            montantF = montant;
        }

<<<<<<< HEAD
        public void setDateFacture(DateTime aaaammjj)
=======
        public void setDateFacture(string aaaammjj)
>>>>>>> bc1f2fb5608bb77cfd02fc21ab51eae0d62f9c0c
        {
            dateFacture = aaaammjj;

        }
<<<<<<< HEAD
        public DateTime getDateFacture()
=======
        public string getDataFacture()
>>>>>>> bc1f2fb5608bb77cfd02fc21ab51eae0d62f9c0c
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
