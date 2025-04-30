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
    public partial class frmListeCredit : Form
    {
        public frmListeCredit()
        {
            InitializeComponent();
            foreach (Credit uncredit in Globales.lesCredits)
            {
                lsbLesCredits.Items.Add(uncredit.getCredit());
            }

        }

        private void listeCredit_Load(object sender, EventArgs e)
        {

        }

        private void btnEnregistre_Click(object sender, EventArgs e)
        {
            // Collection-- > Stockage vers la base de données
            // --> sqlserveur (CréditCeleste , tableCredit)

            // Ecran --> Objets --> BDD

            // il faut récupérer la ligne qui est cliquée

            Credit unCredit = Globales.lesCredits[lsbLesCredits.SelectedIndex];

            string connexionParam = "Data Source=localhost\\SQLEXPRESS;Integrated Security = SSPI; Initial Catalog=CreditCelesteKOPP";
            // Paramètres pour la procédure

            double montantFinale = unCredit.getMontant();
            double tauxFinale = unCredit.getTaux();
            double mensualiteFinale = unCredit.getMensualite();
            double nbMensualite = unCredit.getNbMensu();
            // Appel de la procédure

            using (SqlConnection connexion = new SqlConnection(connexionParam))
            {
                using(SqlCommand command = new SqlCommand("InsCredit", connexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Ajout des paramètres

                    command.Parameters.Add(new SqlParameter("@MontantFin", montantFinale));
                    command.Parameters.Add(new SqlParameter("@nbMens", nbMensualite));
                    command.Parameters.Add(new SqlParameter("@montantMens", mensualiteFinale));
                    command.Parameters.Add(new SqlParameter("@tauxAn", tauxFinale));

                    try
                    {
                        // Ouvrir la connexion
                        connexion.Open();
                        // Exécuter la procédure
                        command.ExecuteNonQuery();
                        Console.WriteLine("Le crédit a été ajouté avec succès.");


                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Erreur lors de l'ajout: {ex.Message} ");
                    }
                }
            }

        }

        private void lsbLesCredits_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdInit_Click(object sender, EventArgs e)
        {
            lsbLesCredits.Items.Clear();

            Globales.lesCredits.Clear();
        }
    }
}
 