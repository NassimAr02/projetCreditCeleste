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
    public partial class frmVoiture : Form
    {
        private string age;
        public frmVoiture()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void frmVoiture_Load(object sender, EventArgs e)
        {
            if (Globales.uneNouvelleVoiture != null)
            {
                txtNvVoiture.Text = Globales.uneNouvelleVoiture.LibeleNouvVoiture;
                dtp1Immat.Value = Globales.uneNouvelleVoiture.DateImmat;
                txtNumImmat.Text = Globales.uneNouvelleVoiture.NumImmat;
                txtNumSerie.Text = Globales.uneNouvelleVoiture.NumeroSerie;
                txtPuis.Text = Globales.uneNouvelleVoiture.Puissance;

                foreach (RadioButton radio in gpbAgeV.Controls.OfType<RadioButton>())
                {
                    if (radio.Text == Globales.uneNouvelleVoiture.Age)
                    {
                        radio.Checked = true; // Vérifiez que l'âge correspond au bouton sélectionné
                    }
                }
            }
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = DbConnexion.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("InsNouvelleVoiture", connection))
                {

                    foreach (RadioButton xRadio in gpbAgeV.Controls)
                    {
                        if (xRadio.Checked)
                        {
                            age = xRadio.Text;
                        }
                    }
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@numeroConcession", Globales.uneConcession.NumConcession));
                    command.Parameters.Add(new SqlParameter("@numImmat", txtNumImmat.Text));
                    command.Parameters.Add(new SqlParameter("dateImmat", dtp1Immat.Value));
                    command.Parameters.Add(new SqlParameter("@numeroSerie", txtNumSerie.Text));
                    command.Parameters.Add(new SqlParameter("@puissance", txtPuis.Text));
                    command.Parameters.Add(new SqlParameter("@age",age));
                    command.Parameters.Add(new SqlParameter("@libeleNouvVoiture", txtNvVoiture.Text));

                    try
                    {
                        // Ouvrir la connexion
                        connection.Open();
                        // Exécuter la procédure
                        command.ExecuteNonQuery();
                        Console.WriteLine("La voiture a été ajouté avec succès.");


                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Erreur lors de l'ajout: {ex.Message} ");
                    }
                }
            }
            // Vérifiez si fenCalcul est null avant de l'initialiser
            if (Globales.fenCalcul == null)
            {
                Globales.fenCalcul = new frmCalculCredit();
            }

            // Affichez fenCalcul, qu'il soit nouvellement créé ou déjà existant
            Globales.fenCalcul.Show();

            // Réinitialisez fenVoiture et fermez le formulaire actuel
            Globales.fenVoiture = null;
            this.Close();
        }

        private void btnPrécédent_Click(object sender, EventArgs e)
        {
            if (Globales.fenIntroduction == null)
            {
                Globales.fenIntroduction = new frmIntroduction();
                Globales.fenIntroduction.Show();
                Globales.fenVoiture = null;
                this.Close();
            }
        }
    }
}
