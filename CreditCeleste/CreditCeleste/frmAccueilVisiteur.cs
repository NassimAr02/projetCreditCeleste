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
    public partial class frmAccueilVisiteur : Form
    {
        public frmAccueilVisiteur()
        {
            InitializeComponent();
        }

        private void btnNouvVisite_Click(object sender, EventArgs e)
        {
            if(Globales.uneVisite == null)
            {
                Globales.uneVisite = new Visite();
                Globales.uneVisite.setIdUser(Globales.idUser);
            }

            //Globales.uneVisite.setIdUser(Globales.idUser);
            if (Globales.fenVisiteur == null)
            {
                Globales.fenVisiteur = new frmVisiteur();

                Globales.fenVisiteur.Show();
                // l'objet Courant 
            }
            //utiliser la base de donnée 

            this.Hide();
        }

        private void ChargerFacturesNonRemboursees()
        {
            lsbFactureNon.Items.Clear();
            try
            {
                using (SqlConnection connexion = DbConnexion.GetConnection())
                {
                    string requete = @"
                        SELECT 
                            F.numFacture, 
                            F.dateFacture, 
                            F.typeFrais, 
                            F.montant, 
                            F.estRembourser, 
                            R.montantR, 
                            R.RAC, 
                            R.commentaire
                        FROM Facture F
                        LEFT JOIN Rembourser RB ON F.numFacture = RB.numFacture
                        LEFT JOIN Remboursement R ON RB.numRemboursement = R.numRemboursement
                        JOIN Visite V ON F.numVisite = V.numVisite
                        WHERE V.idUtilisateur = @idUtilisateur AND F.estRembourser = 0";

                    using (SqlCommand cmd = new SqlCommand(requete, connexion))
                    {
                        cmd.Parameters.AddWithValue("@idUtilisateur", Globales.idUser);
                        connexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int numFacture = reader.GetInt32(0);
                                DateTime dateFacture = reader.GetDateTime(1);
                                string typeFrais = reader.GetString(2);
                                decimal montant = reader.GetDecimal(3);
                                decimal montantR = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5);
                                decimal rac = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);
                                string commentaire = reader.IsDBNull(7) ? "Aucun commentaire" : reader.GetString(7);

                                string factureInfo = $"Facture N°{numFacture} | {dateFacture:dd/MM/yyyy} | {typeFrais} | Montant: {montant:C} | Remboursé: {montantR:C} | RAC: {rac:C} | Commentaire: {commentaire}";
                                lsbFactureNon.Items.Add(factureInfo);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erreur SQL : {ex.Message}");
            }
        }


        private void ChargerFacturesRemboursees()
        {
            lsbFactureOui.Items.Clear(); // vide la listbox

            string requete = @"
        SELECT 
            F.numFacture,
            F.dateFacture,
            F.montant,
            F.typeFrais,
            R.montantR
        FROM 
            Facture F
        INNER JOIN 
            Remboursement R ON F.numFacture = R.numFacture
        WHERE 
            F.estRembourser = 1
    ";

            try
            {
                using (SqlConnection connexion = DbConnexion.GetConnection())
                using (SqlCommand cmd = new SqlCommand(requete, connexion))
                {
                    connexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int numFacture = (int)reader["numFacture"];
                            DateTime date = (DateTime)reader["dateFacture"];
                            decimal montant = (decimal)reader["montant"];
                            decimal montantR = (decimal)reader["montantR"];
                            string typeFrais = reader["typeFrais"].ToString();

                            string ligne = $"Facture N°{numFacture} | {date:dd/MM/yyyy} | {typeFrais} | Montant: {montant:C} | Remboursé: {montantR:C}";
                            lsbFactureOui.Items.Add(ligne);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des factures remboursées : " + ex.Message);
            }
        }

        private void frmAccueilVisiteur_Load(object sender, EventArgs e)
        {
            ChargerFacturesNonRemboursees();
            ChargerFacturesRemboursees();
        }

        private void lsbMesVisites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            if (Globales.fenConnexion == null)
            {
                Globales.fenConnexion = new frmConnexion();
                Globales.fenConnexion.Show();
                Globales.fenAccueil = null;
                this.Hide();
            }
        }
    }
}
