using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace CreditCeleste
{
    public partial class frmConnexion :   Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            string identifiantUser = txtUtilisateur.Text;
            string mdpUser = MDPversMD5.ConversionMD5(txtMdp.Text);

            string connectionParam = "Data Source = 10.129.184.101;User Id=connEleveSio;password=mdpEleveSio2024;Initial Catalog=creditCelesteARRASS";
            string connectionParam2 = "Data Source = 192.168.1.33;User Id=connEleveSio;password=mdpEleveSio2024;Initial Catalog=creditCelesteARRASS";
            using(SqlConnection connection = new SqlConnection(connectionParam))
            {
                using(SqlCommand UserConn = new SqlCommand("SelUserId", connection))
                {
                    UserConn.CommandType = CommandType.StoredProcedure;
                    UserConn.Parameters.Add(new SqlParameter("@userN",identifiantUser));
                    UserConn.Parameters.Add(new SqlParameter("@passwordH", mdpUser));
                    SqlParameter roleP = new SqlParameter("@roleC", SqlDbType.NVarChar, 20)
                    {
                        Direction = ParameterDirection.Output
                    };
                    UserConn.Parameters.Add(roleP);
                    try
                    {
                        connection.Open();
                        UserConn.ExecuteNonQuery();

                        string role = roleP.Value as string;

                        if (!string.IsNullOrEmpty(role))
                        {
                            Form formShow = null;
                            if (role == "Visiteur")
                            { 
                                formShow = new frmVisiteur();

                            }
                            else if (role == "Vendeur")
                            {
                                formShow = new frmAccueil();

                            }
                            else
                            {
                                formShow = new frmComptabilite();
                            }

                            formShow.Show();

                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Aucun rôle n'a été retourné. Vérifiez les informations saisies.");
                        }
                    }
                    catch (SqlException exe)
                    {
                        MessageBox.Show($"Erreur SQL : {exe.Message}");
                    }


                }
            }

        }
    }
}
