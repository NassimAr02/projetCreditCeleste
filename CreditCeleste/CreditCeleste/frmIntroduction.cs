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
    public partial class frmIntroduction : Form
    {
        private string age;
        
        public frmIntroduction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCiv_Click(object sender, EventArgs e)
        {

        }

        private void frmIntroduction_Load(object sender, EventArgs e)
        {
            //mettre les vendeurs dans la comboBox
            foreach (Vendeur unVendeur in Globales.uneConcession.getLesVendeurs())
            {
                cbxVendeur.Items.Add(unVendeur.getInfoVendeur());
            }
            //lblNomVendeur.Text = cbxVendeur.SelectedItem.ToString();
            //lblNomVendeur.Text = le nom du vendeur
            //
            //espace comme séparateur, trim, length, NON
            //
            //la collection des vendeurs 
            //le deuxième de la combobox correspond au deuxième de la collection des vendeurs.
            //il faut regarder quelle ligne est selectionnée
            // le combobox me sert à récupérer l'index
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdVersNouveauClient_Click(object sender, EventArgs e)
        {
            if (Globales.fenAjoutClient == null)
            {
                Globales.fenAjoutClient = new frmAjoutClient();
                Globales.fenAjoutClient.Show();
                Globales.fenIntroduction = null;
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxVendeur.SelectedItem != null)
            {
                lblNomA.Text = cbxVendeur.SelectedItem.ToString();
                lblNomA.Refresh();

            }


        }

        private void ccmdEnregistre_Click(object sender, EventArgs e)
        {
            string affichage = "";
            //affichage = cboCiv.Text + " " + txtNom.Text + " " + txtPrenom.Text;
            affichage += Environment.NewLine;
            affichage += cbxVendeur.Text;
            affichage += Environment.NewLine;


            //
            //age du véhicule
            //1) parcourir chaque radiobutton; if elxe
            //2) parcourir avec un for i 
            //3)parcourir avec un foreach
            //4)While

            foreach (RadioButton xRadio in gpbAgeV.Controls)
            {
                if (xRadio.Checked)
                {

                    affichage += "Age : " + xRadio.Text;
                }
            }
            MessageBox.Show(affichage);




            // création d'un objet voiture; nom, ancienne, age 
            //création si besoin 
            //création d'un objet voiture 
            //s'il existe il faut le récupérer
            // utilsation de client de tp restaurant,
            // ne pas détruire le tp restaurant 
            //création d'une dll, bibliothèque, référence externe
            // ne garder que ce qui est nécessaire 
        }

        private void cmdSaisieBien_Click(object sender, EventArgs e)
        {
            foreach (RadioButton xRadio in gpbAgeV.Controls)
            {
                if (xRadio.Checked)
                {
                    age = xRadio.Text;
                }
            }
            //if (cboCiv.SelectedItem != null)
            // {
            //     civ = cboCiv.SelectedItem.ToString();
            // }
            if ((Globales.fenVoiture == null))
            {
                Globales.fenVoiture = new frmVoiture();

                if ((Globales.uneVoiture == null) && (Globales.unClient == null))
                {
                    Globales.uneVoiture = new Voiture(txtAncVhc.Text, txtNewV.Text, age);
                    //Globales.unClient = new Client(civ,txtNom.Text,txtPrenom.Text);
                }
                else
                {
                    Globales.uneVoiture.setAncVoiture(txtAncVhc.Text);
                    Globales.uneVoiture.setNvVoiture(txtNewV.Text);
                    foreach (RadioButton xRadio in gpbAgeV.Controls)
                    {
                        if (xRadio.Checked)
                        {
                            Globales.uneVoiture.setAge(xRadio.Text);
                        }
                    }
                    //Globales.unClient.setCivilite(cboCiv.SelectedItem.ToString());
                    //Globales.unClient.setNomClient(txtNom.Text);
                    //Globales.unClient.setPrenomClient(txtPrenom.Text);

                }

                Globales.fenVoiture.Show();
                this.Close();
            }
        }

        private void lblNomA_Click(object sender, EventArgs e)
        {


        }

        private void txtVille_TextChanged(object sender, EventArgs e)
        {


        }

        private void cboCiv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdVersBdd_Click(object sender, EventArgs e)
        {
            
            string civ = Globales.unClient.getCivilite();
            string nom = Globales.unClient.getNomClient();
            string prenom = Globales.unClient.getPrenomClient();
            string numRue = Globales.unClient.getNumRueClient();
            string nomRue = Globales.unClient.getNomRueClient();
            string codëPostal = Globales.unClient.getCPClient();
            string ville = Globales.unClient.getVilleClient();
            string numTel = Globales.unClient.getNumTel();
            string dateNaissance = Globales.unClient.getDateNaissance();
            double revenuAnnuel = Globales.unClient.getRevenuAnnuel();
            string profession = Globales.unClient.getProfesssion();
            string nomJeuneFille = Globales.unClient.getNomJeuneFille();

            string connexionParam2 = "Data Source = localhost\\SQLEXPRESS; Integrated Security =SSPI; Initial Catalog=creditCelesteARRASS";
            using (SqlConnection connexion = new SqlConnection(connexionParam2))
            {
                using (SqlCommand command = new SqlCommand("InsClient", connexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Ajout des paramètres

                    command.Parameters.Add(new SqlParameter("@civilite", civ));
                    command.Parameters.Add(new SqlParameter("@nom", nom));
                    command.Parameters.Add(new SqlParameter("@prenom", prenom));
                    command.Parameters.Add(new SqlParameter("@numRue", numRue));
                    command.Parameters.Add(new SqlParameter("@nomRue", nomRue));
                    command.Parameters.Add(new SqlParameter("@codePostal", codëPostal));
                    command.Parameters.Add(new SqlParameter("@ville", ville));
                    command.Parameters.Add(new SqlParameter("@numTel", numTel));
                    command.Parameters.Add(new SqlParameter("@dateNaissance", dateNaissance));
                    command.Parameters.Add(new SqlParameter("@revenuAnnuel", revenuAnnuel));
                    command.Parameters.Add(new SqlParameter("@profession", profession));
                    command.Parameters.Add(new SqlParameter("@nomJeuneFille", nomJeuneFille));

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

        //if (Globales.fenVoiture == null)
        //{
        //    Globales.fenVoiture = new frmVoiture();


        //    if (Globales.uneVoiture == null)
        //    {
        //        Globales.uneVoiture = new Voiture(txtAncVhc.Text, txtNewV.Text, age);

        //    }
        //    else
        //    {
        //        Globales.uneVoiture.setAncVoiture(txtAncVhc.Text);
        //        Globales.uneVoiture.setNvVoiture(txtNewV.Text);
        //        Globales.uneVoiture.setAge(age);


        //} else
        //{
        //    txtNewV.Text = Globales.uneVoiture.getNvVoiture();
        //    txtAncVhc.Text = Globales.uneVoiture.getAncVoiture();
        //    foreach (RadioButton radio in gpbAgeV.Controls.OfType<RadioButton>())
        //    {
        //        if (radio.Text == Globales.uneVoiture.getAge())
        //        {
        //            radio.Checked = true;
        //        }
        //    }
        //}
    }
}



