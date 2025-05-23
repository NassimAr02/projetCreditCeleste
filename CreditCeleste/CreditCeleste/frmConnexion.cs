﻿using System;
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
            //Boolean backdoor = true;
            //Form formshow = null;
            //if (backdoor)
            //{
            //    formshow = new frmAccueil();
            //}
            //else
            //{
            //    MessageBox.Show("Veuillez vous authentifiez ");
            //}
            //formshow.Show();
            //this.Hide();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
           
        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            string identifiantUser = txtUtilisateur.Text;
            string mdpUser = MDPversMD5.ConversionMD5(txtMdp.Text);

            //string connectionParam = "Data Source = 10.129.184.101;User Id=connEleveSio;password=mdpEleveSio24;Initial Catalog=CreditCeleste";
            string connexionParam2 = "Data Source = localhost\\SQLEXPRESS; Integrated Security =SSPI; Initial Catalog=creditCelesteARRASS";
            //string connexionParam2 = "Data Source = 192.168.1.175;User Id=connEleveSio;password=mdpEleveSio24;Initial Catalog=CreditCeleste";
            using (SqlConnection connection = new SqlConnection(connexionParam2))
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
                                this.Hide();
                            }
                            else if (role == "Vendeur")
                            {
                                formShow = new frmAccueil();
                                this.Hide();
                            }
                            else
                            {
                                formShow = new frmComptabilite();
                                this.Hide();
                            }

                            formShow.Show();

                            

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

        private void txtMdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
