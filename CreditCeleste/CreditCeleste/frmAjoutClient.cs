using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmAjoutClient : Form
    {
        
        public frmAjoutClient()
        {
            InitializeComponent();
        }

        private void frmAjoutClient_Load(object sender, EventArgs e)
        {
           
        }

        private void cboCiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiv.SelectedItem != null &&  cboCiv.SelectedItem == "M.")
            {
                txtNomJeuneFille.Enabled = false;
            } else
            {
                txtNomJeuneFille.Enabled = true;
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            int derId;
            string civ = "";
            if (cboCiv.SelectedItem != null)
            {
               civ = cboCiv.SelectedItem.ToString();
            }
            //string connexionParam = "Data Source = 10.129.184.101;User Id=connEleveSio;password=mdpEleveSio24;Initial Catalog=CreditCeleste";
            string connexionParam2 = "Data Source = 192.168.1.175;User Id=connEleveSio;password=mdpEleveSio24;Initial Catalog=CreditCeleste";
            using (SqlConnection connection = new SqlConnection(connexionParam2))
            {
                string dernierId = "SELECT MAX(numeroClient) FROM Client";
                using (SqlCommand command = new SqlCommand(dernierId, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        derId = Convert.ToInt32(result);
                    } else
                    {
                        derId = 0;
                    }
                }
               
            }
            Globales.unClient = new Client(derId+=1,civ,txtNomClient.Text,txtPrenomClient.Text,txtNumRue.Text,txtRue.Text,txtCP.Text,txtVille.Text,dtpDateNaissance.Text,Convert.ToDouble(txtRevenuA.Text),txtProfession.Text,txtNomJeuneFille.Text);

            if(Globales.fenIntroduction == null)
            {
                Globales.fenIntroduction = new frmIntroduction();
                Globales.fenIntroduction.Show();
                Globales.fenAjoutClient = null;
                this.Hide();
            }

        }

        private void txtNomJeuneFille_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (Globales.fenAccueil== null)
            {
                Globales.fenAccueil = new frmAccueil();
                Globales.fenAccueil.Show();
                Globales.fenAjoutClient = null;
                this.Hide();
            }
        }
    }
}
