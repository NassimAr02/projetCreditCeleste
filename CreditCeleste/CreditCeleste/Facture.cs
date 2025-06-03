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

        //Rajouté pour la compta
        private int numFacture;
        private bool estRembourser;


        public Facture (DateTime aaaammjj,string type,double montant, int numVisite)
        {
            dateFacture = aaaammjj;
            typeFrais = type;
            montantF = montant;
            numeroVisite = numVisite;

        }

        public Facture(DateTime aaaammjj, string typeF, double montant, int numVisite, int numF, bool boolRemboursement)
        {
            dateFacture = aaaammjj;
            typeFrais = typeF;
            montantF = montant;
            numeroVisite = numVisite;
            numFacture = numF;
            estRembourser = boolRemboursement;

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
        public int getNumeroVisite()
        {
            return numeroVisite;
        }


    }
}
