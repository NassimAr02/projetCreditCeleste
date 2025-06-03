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
    public partial class frmComptabilite : Form
    {

        public frmComptabilite()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmComptabilite_Load(object sender, EventArgs e)
        {
            Globales.lesVisites = new List<Visite>(); // Création de la liste visite
            Globales.lesFactures = new List<Facture>(); //Création de la liste Facture

            using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreditCeleste"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Visite", con);
                SqlDataReader dr = cmd.ExecuteReader();

                //Visites
                while (dr.Read())
                {
                    Visite v = new Visite(
                        (DateTime)dr["dateDepart"],
                        (DateTime)dr["dateRetour"],
                        (bool)dr["voiturePerso"],
                        (int)dr["idUtilisateur"],
                        (int)dr["numeroConcession"],
                        (int)dr["numVisite"]
                    );

                    Globales.lesVisites.Add(v); //ajout de chaque visite dans la collection
                }

            }

            // On affiche les numéros dans la ListBox
            lstBoxFactures.Items.Clear();
            foreach (Visite v in Globales.lesVisites)
            {
                lstBoxFactures.Items.Add("Visite n°" + v.getNumeroVisite());
            }
        }

        private void lstBoxFactures_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lstBoxFactures.SelectedIndex -> On récupère l'index de l'élément qui a été cliquée
            // Moyen de cliquer sur les visites pour les informations
            if (lstBoxFactures.SelectedIndex >= 0)
            {
                Visite selectedVisite = Globales.lesVisites[lstBoxFactures.SelectedIndex];
                Globales.uneVisite = selectedVisite;

                // Vérification si la fenêtre est fermée ou non
                if (Globales.fenFactureVisite == null || Globales.fenFactureVisite.IsDisposed)
                {
                    Globales.fenFactureVisite = new frmFactureVisite(); //Creation de l'instance
                }

                Globales.fenFactureVisite.Show();
                Globales.fenFactureVisite.AfficherDetailsVisite(selectedVisite.getNumeroVisite()); 
            }

        }

        private void btnBDDfill_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {

        }
    }
}
