using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCeleste
{
    class ClientVoit : Client
    {
        private string dateNaissance, profession, nomJeuneF;
        
        public string revenuAnnuel;

        public ClientVoit() : base(){

        }
        public ClientVoit( string civ, string nomCli, string prenomCli, string adresseCli, string cpCli, string villeC, string numTel, string dateN,string revenuA,string professionC,string nomJeuneF) : base( civ, nomCli, prenomCli, adresseCli,cpCli,villeC,numTel)
        {
            this.dateNaissance = dateN;
            this.revenuAnnuel = revenuA;
            this.profession = professionC;
            this.nomJeuneF = nomJeuneF;
        }

        public void setDateNaissance(string dateN)
        {
            dateNaissance = dateN;
        }
        public string getDateNaissance()
        {
            return dateNaissance;
        }
        public void setRevenuAnnuel(string revenuA)
        {
            revenuAnnuel = revenuA;
        }
        public string getRevenuAnnuel()
        {
            return revenuAnnuel;
        }
        public void setProfession(string professioC)
        {
            profession = professioC;
        }
        public string getProfession()
        {
            return profession;
        }
        public void setNomJeuneF(string nomJeune)
        {
            nomJeuneF = nomJeune;
        }
        public string getNomJeuneF()
        {
            return nomJeuneF;
        }
    }
}
