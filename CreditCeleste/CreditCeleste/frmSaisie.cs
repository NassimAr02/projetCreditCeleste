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

        private void insererFacture(SqlConnection connexion, DateTime dateFacture, string typeFrais, decimal montant)
        {

            using (SqlCommand command = new SqlCommand("InsFacture", connexion))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@dateFacture", dateFacture));
                command.Parameters.Add(new SqlParameter("@typeFrais", typeFrais));
                command.Parameters.Add(new SqlParameter("@montant", montant));
                command.Parameters.Add(new SqlParameter("@numVisite", this.numVisite));
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
                        insererFacture(connexion, dateFacture.Value, "Frais Repas", fraisRepas);

                    if (fraisHotel > 0)
                        insererFacture(connexion, dateFacture.Value, "Frais hôtel", fraisHotel);

                    if (fraisEssence > 0)
                        insererFacture(connexion, dateFacture.Value, "Frais essence", fraisEssence);

                    MessageBox.Show("Enregistrement réussi");
                    this.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }
    }
}
