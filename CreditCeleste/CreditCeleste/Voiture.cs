using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class Voiture
    {

        private string ancienneVoiture;
        private string nouvelleVoiture;
        private string date1immat;
        private string numeroSerie;
        private string puissance;//à créer pour récupérer les valeurs de la voiture.
        private string age;
        private string numImmat;
        public Voiture()
        {
            
        }
        public Voiture(string ancvoiture, string nVoiture,  string ageVoiture)
        {
            ancienneVoiture = ancvoiture;
            nouvelleVoiture = nVoiture;
            age = ageVoiture;

        }
        public Voiture(string ancvoiture,string nVoiture,string dateImmat,string numSerie,string Puissance,string ageVoiture,string numImmatV)
        {
            ancienneVoiture = ancvoiture;
            nouvelleVoiture = nVoiture;
            date1immat = dateImmat;
            numeroSerie = numSerie;
            puissance = Puissance;
            age = ageVoiture;
            numImmat = numImmatV;

        }
        public void setAncVoiture(string ancvoiture)
        {
            ancienneVoiture = ancvoiture;
        }
        public string getAncVoiture()
        {
            return ancienneVoiture;
        }
        public void setNvVoiture(string nvoiture)
        {
           nouvelleVoiture = nvoiture;
        }
        public string getNvVoiture()
        {
            return nouvelleVoiture;
        }
        public void setDateimmat(string date1immatV)
        {
            date1immat=date1immatV;
        }
        public string getDateimmat()
        {
            return date1immat;
        }
        public void setNumSerie(string numSerie)
        {
            numeroSerie = numSerie;
        }
        public string getNumSerie()
        {
            return numeroSerie;
        }
        public void setPuissance(string pui)
        {
            puissance = pui;
        }
        public string getPuissance()
        {
            return puissance;
        }
        public void setAge(string ageVoiture)
        {
            age = ageVoiture;
        }
        public string getAge()
        {
            return age;
        }
        public void setNumImmat(string Immat)
        {
            numImmat = Immat;
        }
        public string getNumImmat()
        {
            return numImmat;
        }
        public string getInfos()
        {
            return ancienneVoiture + " " + nouvelleVoiture + " " + age;
        }
    }
}
