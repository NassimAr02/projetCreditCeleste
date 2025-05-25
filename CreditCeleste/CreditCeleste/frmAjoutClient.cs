using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmAjoutClient : Form
    {
        
        public frmAjoutClient()
        {
            InitializeComponent();
        }

        private void frmAjoutClient_Load(object sender, EventArgs e)
        {
           
        }

        private void cboCiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiv.SelectedItem != null &&  cboCiv.SelectedItem == "M.")
            {
                txtNomJeuneFille.Enabled = false;
            } else
            {
                txtNomJeuneFille.Enabled = true;
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            int derId;
            string civ = "";
            if (cboCiv.SelectedItem != null)
            {
                civ = cboCiv.SelectedItem.ToString();
            }
            string dernierId = "SELECT MAX(numeroClient) FROM Client";
            //string connexionParam2 = "Data Source=172.20.10.5;User Id=connEleveSio;Password=mdpEleveSio2025;Initial Catalog=CreditCeleste";
            string connexionParam2 = "Data Source = localhost\\SQLEXPRESS; Integrated Security =SSPI; Initial Catalog=CreditCeleste";
            using (SqlConnection connection = new SqlConnection(connexionParam2))
            {
                SqlCommand command = new SqlCommand(dernierId, connection);
                connection.Open();

                object result = command.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                {
                    derId = 0;
                }
                else
                {
                    derId = Convert.ToInt32(result);
                }
            }

            // Créer un nouveau client en incrémentant l'ID.
            Globales.unClient = new Client(++derId, civ,
                                           txtNomClient.Text,
                                           txtPrenomClient.Text,
                                           txtNumRue.Text,
                                           txtRue.Text,
                                           txtCP.Text,
                                           txtVille.Text,
                                           dtpDateNaissance.Text,
                                           Convert.ToDouble(txtRevenuA.Text),
                                           txtProfession.Text,
                                           txtNumTel.Text,
                                           txtNomJeuneFille.Text);

            if (Globales.fenIntroduction == null)
            {
                Globales.fenIntroduction = new frmIntroduction();
                Globales.fenIntroduction.Show();
                Globales.fenAjoutClient = null;
                this.Hide();
            }
           
            using (SqlConnection connexion = new SqlConnection(connexionParam2))
            {
                using (SqlCommand command = new SqlCommand("InsClient", connexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Ajout des paramètres
                    Console.WriteLine($"Valeur de NumTel : {Globales.unClient.getNumTel()}");


                    command.Parameters.Add(new SqlParameter("@civilite", civ));
                    command.Parameters.Add(new SqlParameter("@nom", Globales.unClient.getNomClient()));
                    command.Parameters.Add(new SqlParameter("@prenom", Globales.unClient.getPrenomClient()));
                    command.Parameters.Add(new SqlParameter("@numRue", Globales.unClient.getNumRueClient()));
                    command.Parameters.Add(new SqlParameter("@nomRue", Globales.unClient.getNomRueClient()));
                    command.Parameters.Add(new SqlParameter("@codePostal", Globales.unClient.getCPClient()));
                    command.Parameters.Add(new SqlParameter("@ville", Globales.unClient.getVilleClient()));
                    command.Parameters.Add(new SqlParameter("@numTel", Globales.unClient.getNumTel()));
                    command.Parameters.Add(new SqlParameter("@dateNaissance", Convert.ToDateTime(Globales.unClient.getDateNaissance())));
                    command.Parameters.Add(new SqlParameter("@revenuAnnuel", Globales.unClient.getRevenuAnnuel()));
                    command.Parameters.Add(new SqlParameter("@profession", Globales.unClient.getProfesssion()));
                    command.Parameters.Add(new SqlParameter("@nomJeuneFille", Globales.unClient.getNomJeuneFille()));

                    try
                    {
                        // Ouvrir la connexion
                        connexion.Open();
                        // Exécuter la procédure
                        command.ExecuteNonQuery();
                        Console.WriteLine("Le client a été ajouté avec succès.");


                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Erreur lors de l'ajout: {ex.Message} ");
                    }
                }
            }
        }


        private void txtNomJeuneFille_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (Globales.fenAccueil== null)
            {
                Globales.fenAccueil = new frmAccueil();
                Globales.fenAccueil.Show();
                Globales.fenAjoutClient = null;
                this.Hide();
            }
        }
    }
}
