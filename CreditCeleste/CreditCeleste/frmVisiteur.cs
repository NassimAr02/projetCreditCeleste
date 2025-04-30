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
    public partial class frmVisiteur : Form
    {
        private Visite visiteActuelle;
        private DataTable concessionsTable = new DataTable();
        public frmVisiteur()
        {
            InitializeComponent();
            visiteActuelle = Globales.uneVisite;
            dateDepartPicker.Value = DateTime.Today;
            dateRetourPicker.Value = DateTime.Today;

            ChargerConcessions();
        }

        private void ChargerConcessions()
        {
            string connexionString = "Data Source=localhost\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreditCelesteKOPP";
            try
            {
                using (SqlConnection connexion = new SqlConnection(connexionString))
                {
                    string requete = "SELECT numeroConcession, nomConcession FROM Concession";
                    SqlDataAdapter adapter = new SqlDataAdapter(requete, connexion);
                    connexion.Open();
                    adapter.Fill(concessionsTable);

                    cbxConcession.DataSource = concessionsTable;
                    cbxConcession.DisplayMember = "nomConcession";
                    cbxConcession.ValueMember = "numeroConcession";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erreur lors du chargement des concessions : {ex.Message}");
            }
        }

        private void frmVisiteur_Load(object sender, EventArgs e)
        {

        }

        // Procédure pour l'insertion de la visite
        private int insererVisite(SqlConnection connexion, Visite uneVisite)
        {
            int numVisite = -1;
            try
            {
                if (connexion.State != ConnectionState.Open)
                {
                    connexion.Open();
                }

                using (SqlCommand command = new SqlCommand("InsVisite", connexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    MessageBox.Show(
                    $"Paramètres :\n" +
                    $"Date Départ : {uneVisite.getDateDepart()}\n" +
                    $"Date Retour : {uneVisite.getDateRetour()}\n" +
                    $"Voiture Perso : {uneVisite.getVoiturePerso()}\n" +
                    $"Numéro Concession : {uneVisite.getNumeroConcession()}\n" +
                    $"ID User : {uneVisite.getIdUser()}"
                    );

                    command.Parameters.Add(new SqlParameter("@datedepart", uneVisite.getDateDepart()));
                    command.Parameters.Add(new SqlParameter("@dateRetour", uneVisite.getDateRetour()));
                    command.Parameters.Add(new SqlParameter("@voiturePerso", uneVisite.getVoiturePerso()));
                    command.Parameters.Add(new SqlParameter("@numeroConcession", uneVisite.getNumeroConcession()));
                    command.Parameters.Add(new SqlParameter("@idUser", uneVisite.getIdUser()));

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        numVisite = Convert.ToInt32(result);
                        MessageBox.Show($"Visite insérée avec succès. Numéro de visite : {numVisite} ");
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erreur lors de l'insertion dans la base : {ex.Message} ");
            }
            return numVisite;
        }

        private void cmdSuivant_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"ID utilisateur : {Globales.uneVisite.getIdUser()}");
            if (cbxConcession.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner une concession !");
                return;
            }

            if (!radioBtnOui.Checked && !radioBtnNon.Checked)
            {
                MessageBox.Show("Veuillez préciser si vous utilisez votre voiture personnelle !");
                return;
            }

            bool choixVoiturePerso;
            if (radioBtnOui.Checked)
            {
                choixVoiturePerso = true; // Visiteur utilise sa voiture
            }
            else
            {
                choixVoiturePerso = false; // Visiteur utilise un véhicule de la concession
            }

            visiteActuelle.setDateDepart(dateDepartPicker.Value);
            visiteActuelle.setDateRetour(dateRetourPicker.Value);
            visiteActuelle.setVoiturePerso(choixVoiturePerso);
            visiteActuelle.setNumeroConcession((int)cbxConcession.SelectedValue);


            // Connexion à la base de données
            string connexionParam = "Data Source=localhost\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreditCelesteKOPP";
            using (SqlConnection connexion = new SqlConnection(connexionParam))
            {
                // Insertion de la visite
                connexion.Open();
                int numVisite = insererVisite(connexion, visiteActuelle);

                if (numVisite > 0)
                {
                    // Redirection vers frmSaisie avec le numVisite
                    frmSaisie saisieForm = new frmSaisie(numVisite);
                    saisieForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur : La visite n'a pas été créée.");
                }
            }
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            if (Globales.fenAccueilVisiteur == null)
            {
                Globales.fenAccueilVisiteur = new frmAccueilVisiteur();

                Globales.fenAccueilVisiteur.Show();
                // l'objet Courant 
            }
            //utiliser la base de donnée 

            this.Hide();
        }
    }
}
