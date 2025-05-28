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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //Concession uneConcession = new Concession(); 
            //Globales.uneConcession = new Concession("Garage Arrass","66 rue du voyages");
            Vendeur unVendeur = new Vendeur("M.","ARRASS","Nassim");
            Vendeur un2Vendeur = new Vendeur("M.", "GADAEV", "Albert");
            Vendeur un3Vendeur = new Vendeur("M.", "KOPP", "Enzo");
            Globales.uneConcession.ajoutVendeur(unVendeur);
            Globales.uneConcession.ajoutVendeur(un2Vendeur);
            Globales.uneConcession.ajoutVendeur(un3Vendeur);

            lblNomConcession.Text = Globales.uneConcession.MonNomConcession;
            lblNumRue.Text = Globales.uneConcession.NumRueConcession;
            lblRue.Text = Globales.uneConcession.NomRueConcession;
            lblCP.Text = Globales.uneConcession.CpConcession;
            lblVille.Text = Globales.uneConcession.VilleConcession;
        }

        private void cmdIntro_Click(object sender, EventArgs e)
        {
            
            // une seule fenetre ?? 
            // booléen
            //enabled
            // tester si la fenètre existe == null
            // (un singleton ?? un seule instance possible)

            if (Globales.fenAjoutClient == null)
            {
                Globales.fenAjoutClient = new frmAjoutClient();
                
                Globales.fenAjoutClient.Show();
                 // l'objet Courant 
            }
            //utiliser la base de donnée 
            Globales.fenAccueil = null;
            this.Hide();
        }
        private void gestBDD()
        {

        }

        private void cmdEtude_Click(object sender, EventArgs e)
        {

        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            if (Globales.fenConnexion == null)
            {
                Globales.fenConnexion = new frmConnexion();
                Globales.fenConnexion.Show();
                Globales.fenAccueil = null;
                this.Hide();
            }
        }
    }
}
