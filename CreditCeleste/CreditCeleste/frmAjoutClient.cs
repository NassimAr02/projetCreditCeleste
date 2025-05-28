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
            if (Globales.unClient != null)
            {
                cboCiv.SelectedItem = Globales.unClient.getCivilite();
                txtNomClient.Text = Globales.unClient.getNomClient();
                if (cboCiv.SelectedItem != null && cboCiv.SelectedItem == "M.")
                {
                    txtNomJeuneFille.Enabled = false;
                }
                else
                {
                    txtNomJeuneFille.Enabled = true;
                    txtNomJeuneFille.Text = Globales.unClient.getNomJeuneFille();
                }
                txtPrenomClient.Text = Globales.unClient.getPrenomClient();
                dtpDateNaissance.Value = Globales.unClient.getDateNaissance();
                txtNumRue.Text = Globales.unClient.getNumRueClient();
                txtNomClient.Text = Globales.unClient.getNomClient();
                txtCP.Text = Globales.unClient.getCPClient();
                txtVille.Text = Globales.unClient.getVilleClient();
                txtProfession.Text = Globales.unClient.getProfesssion();
                txtRevenuA.Text = Convert.ToString(Globales.unClient.getRevenuAnnuel());
                txtNumTel.Text = Globales.unClient.getNumTel();

            }
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
           
            using (SqlConnection connection = DbConnexion.GetConnection())
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
            if (Globales.unClient == null)
            {
                // Créer un nouveau client en incrémentant l'ID.
                Globales.unClient = new Client(++derId, civ,
                                               txtNomClient.Text,
                                               txtPrenomClient.Text,
                                               txtNumRue.Text,
                                               txtRue.Text,
                                               txtCP.Text,
                                               txtVille.Text,
                                               dtpDateNaissance.Value,
                                               Convert.ToDouble(txtRevenuA.Text),
                                               txtProfession.Text,
                                               txtNumTel.Text,
                                               txtNomJeuneFille.Text);
            } else
            {
                Globales.unClient.setCivilite(civ);
                Globales.unClient.setNomClient(txtNomClient.Text);
                Globales.unClient.setPrenomClient(txtPrenomClient.Text);
                Globales.unClient.setAdresseClient(txtNumRue.Text,txtNomClient.Text,txtCP.Text,txtVille.Text);
                Globales.unClient.setDateNaissance(dtpDateNaissance.Value);
                Globales.unClient.setRevenuAnnuel(Convert.ToDouble(txtRevenuA.Text));
                Globales.unClient.setProfession(txtProfession.Text);
                Globales.unClient.setNumtel(txtNumTel.Text);
                Globales.unClient.setNomJeuneFille(txtNomJeuneFille.Text);
            }
            

            if (Globales.fenIntroduction == null)
            {
                Globales.fenIntroduction = new frmIntroduction();
                Globales.fenIntroduction.Show();
                Globales.fenAjoutClient = null;
                this.Hide();
            }
           
            using (SqlConnection connection = DbConnexion.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("InsClient", connection))
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
                    command.Parameters.Add(new SqlParameter("@dateNaissance", Globales.unClient.getDateNaissance()));
                    command.Parameters.Add(new SqlParameter("@revenuAnnuel", Globales.unClient.getRevenuAnnuel()));
                    command.Parameters.Add(new SqlParameter("@profession", Globales.unClient.getProfesssion()));
                    command.Parameters.Add(new SqlParameter("@nomJeuneFille", Globales.unClient.getNomJeuneFille()));

                    try
                    {
                        // Ouvrir la connexion
                        connection.Open();
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

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            if (Globales.fenConnexion == null)
            {
                Globales.fenConnexion = new frmConnexion();
                Globales.fenConnexion.Show();
                Globales.fenAjoutClient = null;
                this.Hide();
            }
        }
    }
}
