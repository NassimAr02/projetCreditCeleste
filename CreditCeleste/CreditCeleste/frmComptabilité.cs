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


            Visite uneVisite = Globales.lesVisites[lstBoxFactures.SelectedIndex];
        }

        private void lstBoxFactures_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBDDfill_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsulter_Click(object sender, EventArgs e)
        {

        }
    }
}
