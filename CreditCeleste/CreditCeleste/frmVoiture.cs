using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCeleste
{
    public partial class frmVoiture : Form
    {
        public frmVoiture()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ccmdEnregistre_Click(object sender, EventArgs e)
        {
          
        }

        private void frmVoiture_Load(object sender, EventArgs e)
        {
            if (Globales.uneVoiture != null)
            {
                txtNvVoiture.Text = Globales.uneVoiture.getNvVoiture();
                txt1ereImmat.Text = Globales.uneVoiture.getDateimmat();
                txtNumImmat.Text = Globales.uneVoiture.getNumImmat();
                txtNumImmat.Text = Globales.uneVoiture.getNumSerie();
                txtPuis.Text = Globales.uneVoiture.getPuissance();

                foreach (RadioButton radio in gpbAgeV.Controls.OfType<RadioButton>())
                {
                    if (radio.Text == Globales.uneVoiture.getAge())
                    {
                        radio.Checked = true; // Vérifiez que l'âge correspond au bouton sélectionné
                    }
                }
            }
        }


        private void cmdIntro_Click(object sender, EventArgs e)
        {
            if (Globales.fenIntroduction != null)
            {
                Globales.fenIntroduction = new frmIntroduction();
                Globales.uneVoiture.setNvVoiture(txtNvVoiture.Text);
                Globales.uneVoiture.setDateimmat(txt1ereImmat.Text);
                Globales.uneVoiture.setNumImmat(txtNumImmat.Text);
                Globales.uneVoiture.setNumSerie(txtNumSerie.Text);
                Globales.uneVoiture.setPuissance(txt1ereImmat.Text);
                foreach (RadioButton xRadio in gpbAgeV.Controls)
                {
                    if (xRadio.Checked)
                    {
                        Globales.uneVoiture.setAge(xRadio.Text);
                    }
                }
                
                Globales.fenIntroduction.Show();
                 // l'objet Courant 
            }
            Globales.fenVoiture = null;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vérifiez si fenCalcul est null avant de l'initialiser
            if (Globales.fenCalcul == null)
            {
                Globales.fenCalcul = new frmCalculCredit();
            }

            // Affichez fenCalcul, qu'il soit nouvellement créé ou déjà existant
            Globales.fenCalcul.Show();

            // Réinitialisez fenVoiture et fermez le formulaire actuel
            Globales.fenVoiture = null;
            this.Close();
        }

    }
}
