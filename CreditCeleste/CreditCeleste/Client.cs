using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreditCeleste
{
    class Client
    {//a
        private int numeroClient;
        private string nomClient, prenomClient,numRue,nomRue,CP,ville,civilite,dateNaissance,profession,nomJeuneFille;
        private double revenuAnnuel;



        public Client()
        {

        }
        
        public Client(int numCli,string civ, string nomCli, string prenomCli,string numRue, string nomRue, string CP, string ville, string dateNaissance,double revenuAnnuel,string profession,string nomJeuneFille)
        {
            numeroClient = numCli;
            civilite = civ;
            nomClient = nomCli;
            prenomClient = prenomCli;
            this.numRue = numRue;
            this.nomRue = nomRue;
            this.CP = CP;
            this.ville = ville;
            this.dateNaissance = dateNaissance;
            this.revenuAnnuel = revenuAnnuel;
            this.profession = profession;
            this.nomJeuneFille = nomJeuneFille;
        }
        public void setNumeroClient(int numCli)
        {
            numeroClient = numCli;
        }
        public int getNumeroClient()
        {
            return numeroClient;
        }
        public void setCivilite(string civ)
        {
            civilite = civ;
        }
        public string getCivilite()
        {
            return civilite;
        }
        public void setNomClient(string nomCli)
        {
            nomClient = nomCli;
        }
        public string getNomClient()
        {
            return nomClient;
        }
        public void setPrenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }
        public string getPrenomClient()
        {
            return prenomClient;
        }
        
        public void setAdresseClient(string num, string rue, string cp,string ville)
        {
            numRue = num;
            nomRue = rue;
            CP = cp;
            this.ville = ville;
        }
        public string getNumRueClient()
        {
            return numRue;
        }
        public string getNomRueClient()
        {
            return nomRue;
        }
        public string getCPClient()
        {
            return CP;
        }
        public string getVilleClient()
        {
            return ville;
        }
        public void setDateNaissance (string dateNaiss)
        {
            dateNaissance = dateNaiss;
        }
        public string getDateNaissance()
        {
            return dateNaissance;
        }
        public void setRevenuAnnuel(double revenu)
        {
            revenuAnnuel = revenu;
        }
        public double getRevenuAnnuel()
        {
            return revenuAnnuel;
        }
        public void setProfession (string professi)
        {
            profession = professi;
        }
        public string getProfesssion()
        {
            return profession;
        }
        public void setNomJeuneFille(string nomJF)
        {
            nomJeuneFille = nomJF;
        }
        public string getNomJeuneFille()
        {
            return nomJeuneFille;
        }

    }
}

       
