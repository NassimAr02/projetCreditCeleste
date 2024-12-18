using System;
using System.Linq;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmIntroduction : Form
    {
        private string age;
        private string civ;
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

        private void cmdVersBdd_Click(object sender, EventArgs e)
        {

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
            affichage = cboCiv.Text + " " + txtNom.Text + " " + txtPrenom.Text;
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
                    age = xRadio.Text ;
                }
            }
           if (cboCiv.SelectedItem != null)
            {
                civ = cboCiv.SelectedItem.ToString();
            }
            if ((Globales.fenVoiture == null))
            {
                Globales.fenVoiture = new frmVoiture();

                if ((Globales.uneVoiture == null) &&(Globales.unClient ==null))
                {
                    Globales.uneVoiture = new Voiture(txtAncVhc.Text, txtNewV.Text, age);
                    Globales.unClient = new Client(civ,txtNom.Text,txtPrenom.Text);
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
                    Globales.unClient.setCivilite(cboCiv.SelectedItem.ToString());
                    Globales.unClient.setNomClient(txtNom.Text);
                    Globales.unClient.setPrenomClient(txtPrenom.Text);
                    
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
    


