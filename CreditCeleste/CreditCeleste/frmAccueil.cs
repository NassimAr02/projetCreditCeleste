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
            lblMonApp.Text = "ARRASS";
            //création de l'objet 
            // gestion de ma région
            lblMaRegion.Text = Globales.maRegion;
            lblMonApp.Text = Globales.nomUtilisateur;

            //Concession uneConcession = new Concession(); 
            Globales.uneConcession = new Concession("Garage Arrass","66 rue du voyages");
            Vendeur unVendeur = new Vendeur("M.","ARRASS","Nassim");
            Vendeur un2Vendeur = new Vendeur("M.", "GADAEV", "Albert");
            Vendeur un3Vendeur = new Vendeur("M.", "KOPP", "Enzo");
            Globales.uneConcession.ajoutVendeur(unVendeur);
            Globales.uneConcession.ajoutVendeur(un2Vendeur);
            Globales.uneConcession.ajoutVendeur(un3Vendeur);
            
        }

        private void cmdIntro_Click(object sender, EventArgs e)
        {
            
            // une seule fenetre ?? 
            // booléen
            //enabled
            // tester si la fenètre existe == null
            // (un singleton ?? un seule instance possible)

            if (Globales.fenIntroduction == null)
            {
                Globales.fenIntroduction = new frmIntroduction();
                
                Globales.fenIntroduction.Show();
                 // l'objet Courant 
            }
            //utiliser la base de donnée 

            this.Hide();
        }
        private void gestBDD()
        {

        }

        private void cmdEtude_Click(object sender, EventArgs e)
        {

        }
    }
}
