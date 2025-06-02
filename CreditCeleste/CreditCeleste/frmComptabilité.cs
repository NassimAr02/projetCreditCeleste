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

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public frmComptabilite()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmComptabilite_Load(object sender, EventArgs e)
        {
            Globales.lesVisites = new List<Visite>(); // initialiser la liste

            using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=CreditCeleste"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Visite", con);
                SqlDataReader dr = cmd.ExecuteReader();

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

                    Globales.lesVisites.Add(v);
                }
            }

            // On affiche les numéros dans la ListBox
            lstBoxFactures.Items.Clear();
            foreach (Visite v in Globales.lesVisites)
            {
                lstBoxFactures.Items.Add("Visite n°" + v.getNumeroVisite());
            }







            //con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Integrated Security =SSPI; Initial Catalog=CreditCeleste");
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;

            //cmd.CommandText = "SELECT * FROM Visite";


            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    lstBoxFactures.Items.Add("Visite numéro : " + dr["numVisite"].ToString());
            //}
            //con.Close();


            //Visite uneVisite = Globales.lesVisites[lstBoxFactures.SelectedIndex];
        }

        private void lstBoxFactures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxFactures.SelectedIndex >= 0)
            {
                Visite selectedVisite = Globales.lesVisites[lstBoxFactures.SelectedIndex];
                Globales.uneVisite = selectedVisite;

                if (Globales.fenFactureVisite == null || Globales.fenFactureVisite.IsDisposed)
                {
                    Globales.fenFactureVisite = new frmFactureVisite();
                }

                Globales.fenFactureVisite.Show();
                Globales.fenFactureVisite.AfficherDetailsVisite(selectedVisite.getNumeroVisite()); // méthode à créer
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
