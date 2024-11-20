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
        private string nomClient, prenomClient, adresseClient, civilite;
        
        public Client()
        {

        }
        public Client(int numCli)
        {

        }
        public Client(string civ,string nomCli, string prenomCli)
        {
            numeroClient =0 ;
            civilite = civ;
            nomClient = nomCli;
            prenomClient = prenomCli;

        }
        public Client(int numCli,string civ, string nomCli, string prenomCli)
        {
            numeroClient = numCli;
            civilite = civ;
            nomClient = nomCli;
            prenomClient = prenomCli;
            
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
        public void setAdresseClient(string addresseCli)
        {
            adresseClient = addresseCli;
        }
        public string getAdresseClient()
        {
            return adresseClient;
        }
     
    }
}

       
