using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Credit
    {
        private double monMontant;
        private double monDuree;
        private double monTaux;
        private double monMensualite;
        private List<Credit> credits;

        public Credit(double montant,double duree, double taux)
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
            monMensualite = 0;
        }
        public Credit(double montant, double duree, double taux, double mensualite)
        {
            monMontant = montant;
            monDuree = duree;
            monTaux = taux;
            monMensualite = mensualite;
        }
        public double getMensualite()
        {
            double tauxMens = monTaux / 1200;
            monMensualite = Math.Round((monMontant * tauxMens) / (1 - Math.Pow(1 + tauxMens, -monDuree)), 2);
            return monMensualite;
        }
        public string getCredit()
        {
            string resultat = $"{monMontant} {monDuree} {monMensualite} {monTaux}";
            return resultat;

        }
        public void addCredit(Credit unCredit)
        {
            credits.Add(unCredit);
        }
    }
}
