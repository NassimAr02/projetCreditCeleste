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
    public partial class frmSaisie : Form
    {
        private int numVisite;
        public frmSaisie()
        {
            InitializeComponent();
        }

        public frmSaisie(int numeroVisite)
        {
            InitializeComponent();
            numVisite = numeroVisite;
        }


        private void frmSaisie_Load(object sender, EventArgs e)
        {

        }

        private void insererFacture(SqlConnection connexion, Facture facture)
        {

            using (SqlCommand command = new SqlCommand("InsFacture", connexion))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@dateFacture", facture.getDateFacture()));
                command.Parameters.Add(new SqlParameter("@typeFrais", facture.getTypeFrais()));
                command.Parameters.Add(new SqlParameter("@montant", facture.getMontantF()));
                command.Parameters.Add(new SqlParameter("@numVisite", facture.getNumeroVisite()));
                command.Parameters.Add(new SqlParameter("@estRembourser", false));

                command.ExecuteNonQuery();
            }
        }

        private void cmdEnvoyer_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtFraisRepas.Text, out decimal fraisRepas) ||
                !decimal.TryParse(txtFraisHotel.Text, out decimal fraisHotel) ||
                !decimal.TryParse(txtFraisEssence.Text, out decimal fraisEssence))
            {
                MessageBox.Show("Veuillez saisir des montants valides !");
                return;
            }

            if (fraisRepas < 0 || fraisHotel < 0 || fraisEssence < 0)
            {
                MessageBox.Show("Les montants ne peuvent pas être négatifs !");
                return;
            }

            //string connexionParam = "Data Source=localhost\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreditCelesteKOPP";
            try
            {
                using (SqlConnection connexion = DbConnexion.GetConnection())
                {
                    connexion.Open();
                    if (fraisRepas > 0)
                    {
                        Facture fRepas = new Facture(dateFacture.Value, "Frais Repas", fraisRepas, numVisite);
                        insererFacture(connexion, fRepas);
                    }

                    if (fraisHotel > 0)
                    {
                        Facture fHotel = new Facture(dateFacture.Value, "Frais hôtel", fraisHotel, numVisite);
                        insererFacture(connexion, fHotel);
                    }

                    if (fraisEssence > 0)
                    {
                        Facture fEssence = new Facture(dateFacture.Value, "Frais essence", fraisEssence, numVisite);
                        insererFacture(connexion, fEssence);
                    }

                    MessageBox.Show("Enregistrement réussi");
                    if (Globales.fenAccueilVisiteur == null || Globales.fenAccueilVisiteur.IsDisposed)
                    {
                        Globales.fenAccueilVisiteur = new frmAccueilVisiteur();
                    }
                    Globales.fenAccueilVisiteur.Show();

                    // Fermer la fenêtre actuelle
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }
    }
}
