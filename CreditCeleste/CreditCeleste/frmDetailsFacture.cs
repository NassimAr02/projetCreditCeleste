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
    public partial class frmDetailsFacture : Form
    {
        public frmDetailsFacture()
        {
            InitializeComponent();
        }

        private void frmDetailsFacture_Load(object sender, EventArgs e)
        {
            if (lblTypeFrais.Text == "Carburant" || lblTypeFrais.Text == "carburant")
            {
                txtDistance.Enabled = true;
                lblDistance.Enabled = true;
            } else
            {
                txtDistance.Enabled = false;
                lblDistance.Enabled = false;
            }
        }

        public void AfficherDetailsFacture(int numFacture)
        {
            string chaineConnexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CreditCeleste;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(chaineConnexion))
            {
                con.Open();

                // 1. Récupération des données de la facture
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                F.numFacture,
                F.dateFacture,
                F.typeFrais,
                F.montant,
                F.numVisite,
                F.estRembourser
            FROM Facture F
            WHERE F.numFacture = @numFacture", con);

                cmd.Parameters.AddWithValue("@numFacture", numFacture);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    lblNumFacture.Text = "Numéro Facture : " + dr["numFacture"];
                    lblTypeFrais.Text = "Type de frais : " + dr["typeFrais"];
                    lblMontant.Text = "Montant : " + dr["montant"] + "€";
                    lblDateFacture.Text = "Date : " + Convert.ToDateTime(dr["dateFacture"]).ToShortDateString();
                    lblRembourserBool.Text = ((bool)dr["estRembourser"] ? "Remboursé" : "Non Remboursé");
                }
                dr.Close();

                // 2. Récupération du remboursement associé, s'il existe
                SqlCommand cmdRemb = new SqlCommand(@"
            SELECT TOP 1 RAC
            FROM Remboursement
            WHERE numFacture = @numFacture", con);

                cmdRemb.Parameters.AddWithValue("@numFacture", numFacture);

                object result = cmdRemb.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    decimal rac = Convert.ToDecimal(result);
                    lblRAC.Text = "Reste à charge : " + rac.ToString("0.00") + "€";
                }
                else
                {
                    lblRAC.Text = "Reste à charge : -";
                }
            }
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBoxMontantRembourser.Text, out decimal montantRembourse))
            {
                MessageBox.Show("Veuillez entrer un montant valide.");
                return;
            }

            int numFacture = Globales.uneFacture.getNumeroFacture();
            bool estRembourser = radioButtonRembourseTrue.Checked;

            string chaineConnexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CreditCeleste;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(chaineConnexion))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // 1. Récupérer le montant de la facture
                    decimal montantFacture = 0;

                    SqlCommand cmdGetMontant = new SqlCommand(
                        "SELECT montant FROM Facture WHERE numFacture = @numFacture", con, transaction);
                    cmdGetMontant.Parameters.AddWithValue("@numFacture", numFacture);

                    object result = cmdGetMontant.ExecuteScalar();
                    if (result != null)
                        montantFacture = Convert.ToDecimal(result);
                    else
                        throw new Exception("Facture introuvable.");

                    // 2. Calcul du reste à charge
                    decimal resteACharge = montantFacture - montantRembourse;
                    if (resteACharge < 0) resteACharge = 0; // optionnel : éviter valeur négative

                    // 3. Insertion dans Remboursement et récupération de numRemboursement
                    SqlCommand insertRemb = new SqlCommand(@"
                    INSERT INTO Remboursement (numFacture, montantR, RAC, commentaire)
                    VALUES (@numFacture, @montantR, @rac, @commentaire);
                    SELECT CAST(SCOPE_IDENTITY() AS INT);", con, transaction);

                    insertRemb.Parameters.AddWithValue("@numFacture", numFacture);
                    insertRemb.Parameters.AddWithValue("@montantR", montantRembourse);
                    insertRemb.Parameters.AddWithValue("@rac", resteACharge);
                    insertRemb.Parameters.AddWithValue("@commentaire", DBNull.Value);

                    // Exécution + récupération de l'ID généré
                    int numRemboursement = (int)insertRemb.ExecuteScalar();


                    // 4. Insertion dans Rembourser
                    SqlCommand insertRembourser = new SqlCommand(@"
                    INSERT INTO Rembourser (numRemboursement, numFacture)
                    VALUES (@numRemboursement, @numFacture);", con, transaction);

                    insertRembourser.Parameters.AddWithValue("@numRemboursement", numRemboursement);
                    insertRembourser.Parameters.AddWithValue("@numFacture", numFacture);
                    insertRembourser.ExecuteNonQuery();



                    // 5. Mise à jour de la facture
                    SqlCommand updateFacture = new SqlCommand(@"
                    UPDATE Facture
                    SET estRembourser = @estRembourse
                    WHERE numFacture = @numFacture;", con, transaction);

                    updateFacture.Parameters.AddWithValue("@estRembourse", estRembourser);
                    updateFacture.Parameters.AddWithValue("@numFacture", numFacture);
                    updateFacture.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Remboursement enregistré !");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void txtDistance_TextChanged(object sender, EventArgs e) 
        {
            double dist = Convert.ToDouble(txtDistance.Text);
            if (Globales.uneVisite.getPuissanceVoiture() == 3)
            {
                txtBoxMontantRembourser.Text = Convert.ToString(0.52 * dist);
            } else if (Globales.uneVisite.getPuissanceVoiture() == 4)
            {
                txtBoxMontantRembourser.Text = Convert.ToString(0.6 * dist);
            } else if (Globales.uneVisite.getPuissanceVoiture() == 5)
            {
                txtBoxMontantRembourser.Text = Convert.ToString(0.63 * dist);
            } else if (Globales.uneVisite.getPuissanceVoiture() == 6)
            {
                txtBoxMontantRembourser.Text = Convert.ToString(0.66 * dist);
            } else
            {
                txtBoxMontantRembourser.Text = Convert.ToString(0.69 * dist);
            }
        }
    }
}
