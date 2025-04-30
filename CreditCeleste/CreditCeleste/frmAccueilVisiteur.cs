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
    public partial class frmAccueilVisiteur : Form
    {
        public frmAccueilVisiteur()
        {
            InitializeComponent();
        }

        private void btnNouvVisite_Click(object sender, EventArgs e)
        {
            if (Globales.fenVisiteur == null)
            {
                Globales.fenVisiteur = new frmVisiteur();

                Globales.fenVisiteur.Show();
                // l'objet Courant 
            }
            //utiliser la base de donnée 

            this.Hide();
        }

        private void frmAccueilVisiteur_Load(object sender, EventArgs e)
        {

        }

        private void lsbMesVisites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
