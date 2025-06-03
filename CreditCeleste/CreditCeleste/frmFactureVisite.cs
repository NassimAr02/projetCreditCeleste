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

// Liste les factures d'une visite 

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
            Globales.lesFactures = new List<Facture>();
            using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreditCeleste"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Facture", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Facture f = new Facture(
                        (DateTime)dr["dateFacture"],
                        (string)dr["typeFrais"],
                        (float)dr["montant"],
                        (int)dr["numVisite"],
                        (int)dr["numFacture"],
                        (bool)dr["estRembourser"]
                    );

                    Globales.lesFactures.Add(f);

                }
            }

        }

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

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void lstFactures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFactures.SelectedIndex >= 0)
            {
                Facture selectedFacture = Globales.lesFactures[lstFactures.SelectedIndex];
                Globales.uneFacture = selectedFacture;

                // Vérification si la fenêtre est fermée ou non
                if (Globales.fenDetailsFacture == null || Globales.fenDetailsFacture.IsDisposed)
                {
                    Globales.fenDetailsFacture = new frmDetailsFacture(); //Creation de l'instance
                }

                Globales.fenDetailsFacture.Show();
                //Globales.fenDetailsFacture.AfficherDetailsVisite(selectedFacture.getNumeroVisite());
            }
        }
    }
}
