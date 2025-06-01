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
            con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Integrated Security =SSPI; Initial Catalog=CreditCeleste");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM Visite";


            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lstBoxFactures.Items.Add("Visite numéro : " + dr["numVisite"].ToString());
            }
            con.Close();


            //Visite uneVisite = Globales.lesVisites[lstBoxFactures.SelectedIndex];
        }

        private void lstBoxFactures_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nous permet de cliquer sur un élément de la listbox

            if (lstBoxFactures.SelectedItem != null)
            {
                // Exemple avec une simple valeur
                string selectedItem = lstBoxFactures.SelectedItem.ToString();
                char selectedItemVisite = selectedItem[selectedItem.Count() - 1]; // à commenter si ça ne fonctionne pas //Recupere le numero de la visite

                con = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Integrated Security =SSPI; Initial Catalog=CreditCeleste");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM Visite WHERE numVisite = " + selectedItemVisite.ToString();
                dr = cmd.ExecuteReader();

                //MessageBox.Show(dr["numVisite"].ToString());




                //MessageBox.Show("Tu as cliqué sur : " + selectedItem[selectedItem.Count() - 1]); //Je récupère le numero de la visite

                // Voir si j'ouvre une nouvelle form de cette facon après le clic
                //Form formShow = null;
                //formShow = new frmComptabilite(); //Remplacer par la nouvelle form qu'on va créer
                //Globales.fenConnexion = null;
                //this.Hide();
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
