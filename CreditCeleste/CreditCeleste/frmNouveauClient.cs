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
    public partial class frmNouveauClient : Form
    {
        private string civ;
        public frmNouveauClient()
        {
            InitializeComponent();
            
        }

        private void frmNouveauClient_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (cboCiv.SelectedItem != null)
            {
                civ = cboCiv.SelectedItem.ToString();
            }

            Globales.unClient = new Client(civ, txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtCodePostal.Text, txtVille.Text, txtNumTel.Text);
            Globales.unClientVoit = new ClientVoit(civ, txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtCodePostal.Text, txtVille.Text, txtNumTel.Text, dtpDateN.Text, txtRevenu.Text, txtProfession.Text, txtNomJeuneF.Text);
            if (Globales.fenVoiture == null)
            {
                Globales.fenVoiture = new frmVoiture();
                Globales.fenVoiture.Show();
                Globales.fenNouveauClient = null;
                this.Hide();
            }

            string connexionParam2 = "Data Source = localhost\\SQLEXPRESS; Integrated Security =SSPI; Initial Catalog=creditCelesteDevoir";
            using (SqlConnection connexion = new SqlConnection(connexionParam2))
            {
                using (SqlCommand command = new SqlCommand("InsClient", connexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Ajout des paramètres

                    command.Parameters.Add(new SqlParameter("@civilite", civ);
                    command.Parameters.Add(new SqlParameter("@nom", nbMensualite));
                    command.Parameters.Add(new SqlParameter("@prenom", mensualiteFinale));
                    command.Parameters.Add(new SqlParameter("@adresseClient", tauxFinale))
                    command.Parameters.Add(new SqlParameter("@codePostal", montantFinale));
                    command.Parameters.Add(new SqlParameter("@numTel", nbMensualite));
                    command.Parameters.Add(new SqlParameter("@dateNaissance", mensualiteFinale));
                    command.Parameters.Add(new SqlParameter("@revenuAnnuel", tauxFinale));
                    command.Parameters.Add(new SqlParameter("@numTel", nbMensualite));
                    command.Parameters.Add(new SqlParameter("@professione", mensualiteFinale));
                    command.Parameters.Add(new SqlParameter(" @nomJeuneFille", tauxFinale));

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

            private void btnPrecedent_Click(object sender, EventArgs e)
            {
            if (Globales.fenIntroduction == null)
            {
                Globales.fenIntroduction = new frmIntroduction();

                Globales.fenIntroduction.Show();
                Globales.fenNouveauClient = null;
                this.Hide();
                // l'objet Courant 
            }
        }
    }
}
