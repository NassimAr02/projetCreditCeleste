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
    public partial class frmConnexion : Form
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

            string concess = "SELECT * FROM Concession WHERE numeroConcession = @numConcession";

            using (SqlConnection connection = DbConnexion.GetConnection())
            {
                using (SqlCommand UserConn = new SqlCommand("SelUserId", connection))
                {
                    UserConn.CommandType = CommandType.StoredProcedure;
                    UserConn.Parameters.Add(new SqlParameter("@userN", identifiantUser));
                    UserConn.Parameters.Add(new SqlParameter("@passwordH", mdpUser));
                    SqlParameter roleP = new SqlParameter("@roleC", SqlDbType.NVarChar, 20)
                    {
                        Direction = ParameterDirection.Output
                    };
                    SqlParameter numConcession = new SqlParameter("@numConcession", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    UserConn.Parameters.Add(roleP);
                    UserConn.Parameters.Add(numConcession);

                    try
                    {
                        connection.Open();
                        UserConn.ExecuteNonQuery();

                        string role = roleP.Value as string;
                        int numC = numConcession.Value != DBNull.Value ? Convert.ToInt32(numConcession.Value) : -1;

                        if (numC == -1)
                        {
                            MessageBox.Show("Aucune concession assignée à cet utilisateur.");
                            return;
                        }

                        if (!string.IsNullOrEmpty(role))
                        {
                            Form formShow = null;
                            if (role  == "Visiteur")
                            {
                                formShow = new frmVisiteur();
                                Globales.fenConnexion = null;
                                this.Hide();
                            }
                            else if (role == "Vendeur")
                            {
                                formShow = new frmAccueil();
                                using (SqlCommand concessCmd = new SqlCommand(concess, connection))
                                {
                                    concessCmd.Parameters.AddWithValue("@numConcession", numC);
                                    using (SqlDataReader reader = concessCmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            // Use column names instead of ordinals to avoid index errors
                                            int numCon = reader["numeroConcession"] != DBNull.Value ?
                                                Convert.ToInt32(reader["numeroConcession"]) : -1;
                                            string nomCon = reader["nomConcession"] != DBNull.Value ?
                                                reader["nomConcession"].ToString() : "";
                                            string numRue = reader["numRueConcession"] != DBNull.Value ?
                                                reader["numRueConcession"].ToString() : "";
                                            string nomRue = reader["nomRueConcession"] != DBNull.Value ?
                                                reader["nomRueConcession"].ToString() : "";
                                            string cp = reader["codePostalConcession"] != DBNull.Value ?
                                                reader["codePostalConcession"].ToString() : "";
                                            string villeConc = reader["villeConcession"] != DBNull.Value ?
                                                reader["villeConcession"].ToString() : "";

                                            Globales.uneConcession = new Concession(numCon, nomCon, numRue, nomRue, cp, villeConc);
                                            Console.WriteLine(numCon);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Aucune concession trouvée pour ce vendeur.");
                                            return; // Don't continue if no concession found
                                        }
                                    }
                                }
                                Globales.fenConnexion = null;
                                this.Hide();
                            }
                            else
                            {
                                formShow = new frmComptabilite();
                                Globales.fenConnexion = null;
                                this.Hide();
                            }

                            if (formShow != null)
                            {
                                formShow.Show();
                            }
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
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur : {ex.Message}");
                    }
                }
            }
        }

        private void txtMdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}