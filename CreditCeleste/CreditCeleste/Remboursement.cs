using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Remboursement
    {
        private int numFacture;
        private double RAC; // Reste à charge
        private string commentaire; //Commentaire à propos de la facture

        public Remboursement(int unNumFacture, double unRAC, string unCommentaire)
        {
            numFacture = unNumFacture;
            RAC = unRAC;
            commentaire = unCommentaire;
        }

        //setters 
        public void setNumFacture(int unNumFacture)
        {
            numFacture = unNumFacture;
        }

        public void setRAC(double unRAC)
        {
            RAC = unRAC;
        }

        public void setCommentaire(string unCommentaire)
        {
            commentaire = unCommentaire;
        }

        //Getters
        public int getNumFacture()
        {
            return numFacture;
        }

        public double getRAC()
        {
            return RAC;
        }

        public string getCommentaire()
        {
            return commentaire;
        }

    }
}
