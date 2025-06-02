using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CreditCeleste
{
    public partial class frmFactureVisite : Form
    {
        public frmFactureVisite()
        {
            InitializeComponent();
        }

        private void frmFactureVisite_Load(object sender, EventArgs e)
        {

        }

        //public void AfficherDetailsVisite(int numVisite)
        //{
        //    using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreditCeleste"))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM Visite WHERE numVisite = @num", con);
        //        cmd.Parameters.AddWithValue("@num", numVisite);

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            lblNum.Text = "Numéro de visite : " + dr["numVisite"];
        //            lblDateDep.Text = "Date départ : " + dr["dateDepart"];
        //            lblDateRet.Text = "Date retour : " + dr["dateRetour"];
        //            lblVoiturePerso.Text = "Voiture perso : " + ((bool)dr["voiturePerso"] ? "Oui" : "Non");
        //            lblUser.Text = "Utilisateur ID : " + dr["idUser"];
        //            lblConcession.Text = "Concession : " + dr["numeroConcession"];
        //        }
        //    }
        //}




        public void AfficherDetailsVisite(int numVisite)
        {
            string chaineConnexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CreditCeleste;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(chaineConnexion))
            {
                con.Open();

                // Récupération des infos de la visite + utilisateur + concession
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                V.numVisite,
                V.dateDepart,
                V.dateRetour,
                V.voiturePerso,
                V.puissanceVoiture,
                V.distanceVisite,
                U.nomCollaborateur,
                U.prenomCollaborateur,
                C.nomConcession
            FROM Visite V
            INNER JOIN Utilisateur U ON V.idUtilisateur = U.idUtilisateur
            INNER JOIN Concession C ON V.numeroConcession = C.numeroConcession
            WHERE V.numVisite = @numVisite", con);

                cmd.Parameters.AddWithValue("@numVisite", numVisite);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblNum.Text = "Numéro visite : " + dr["numVisite"];
                    lblDateDep.Text = "Date départ : " + Convert.ToDateTime(dr["dateDepart"]).ToShortDateString();
                    lblDateRet.Text = "Date retour : " + Convert.ToDateTime(dr["dateRetour"]).ToShortDateString();
                    lblVoiturePerso.Text = "Voiture perso : " + ((bool)dr["voiturePerso"] ? "Oui" : "Non");
                    lblPuissance.Text = "Puissance : " + dr["puissanceVoiture"].ToString() + " CV";
                    lblDistance.Text = "Distance : " + dr["distanceVisite"].ToString() + " km";
                    lblUser.Text = "Effectuée par : " + dr["prenomCollaborateur"] + " " + dr["nomCollaborateur"];
                    lblConcession.Text = "Concession : " + dr["nomConcession"];
                }
                dr.Close();

                // Récupération des factures associées à cette visite
                SqlCommand cmdFactures = new SqlCommand(@"
            SELECT numFacture, dateFacture, typeFrais, montant, estRembourser
            FROM Facture
            WHERE numVisite = @numVisite", con);

                cmdFactures.Parameters.AddWithValue("@numVisite", numVisite);
                SqlDataReader drFactures = cmdFactures.ExecuteReader();

                lstFactures.Items.Clear();
                while (drFactures.Read())
                {
                    string facture = $"Facture #{drFactures["numFacture"]} - {Convert.ToDateTime(drFactures["dateFacture"]).ToShortDateString()} - {drFactures["typeFrais"]} - {drFactures["montant"]} € - {(Convert.ToBoolean(drFactures["estRembourser"]) ? "Remboursée" : "Non remboursée")}";
                    lstFactures.Items.Add(facture);
                }
                drFactures.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
