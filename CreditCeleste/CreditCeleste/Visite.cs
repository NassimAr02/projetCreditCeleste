using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Visite
    {
        private DateTime dateDepart = new DateTime();
        private DateTime dateRetour = new DateTime();
        private bool voiturePerso;
        private int idUser;
        private int numeroConcession;
        private int numVisite { get; set; }

   
        public Visite(DateTime dateD, DateTime dateR, bool voiturePers, int idU,int numC)
        {
            dateDepart = dateD;
            dateRetour = dateR;
            voiturePerso = voiturePers;
            idUser = idU;
            numeroConcession = numC;
        }

        public Visite(DateTime dateD, DateTime dateR, bool voiturePers, int idU, int numC, int numV)
        {
            dateDepart = dateD;
            dateRetour = dateR;
            voiturePerso = voiturePers;
            idUser = idU;
            numeroConcession = numC;
            numVisite = numV;
        }

        public void setDateDepart(DateTime dateD)
        {
            dateDepart = dateD;
        }
        public DateTime getDateDepart()
        {
            return dateDepart;
        }

        public void setDateRetour(DateTime dateR)
        {
            dateRetour = dateR;
        }
        public DateTime getDateRetour()
        {
            return dateRetour;
        }
        
        public void setVoiturePerso(bool voitureP)
        {
            voiturePerso = voitureP;
        }
        public bool getVoiturePerso()
        {
            return voiturePerso;
        }
        public void setIdUser(int idU)
        {
            idUser = idU;
        }
        public int getIdUser()
        {
            return idUser;
        }
        public void setNumeroConcession(int numC)
        {
            numeroConcession = numC;
        }
        public int getNumeroConcession()
        {
            return numeroConcession;
        }

        public int NumeroVisite
        {
            get { return numVisite; }
            set { numVisite = value; }
        }
    }
}
