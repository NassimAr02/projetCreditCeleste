﻿using System;
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
    public partial class frmCalculCredit : Form
    {//ceci est un test push
        public frmCalculCredit()
        {
            InitializeComponent();
        }

        private void frmCalculCredit_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i < 180; i++)
            {
                cbxDurée.Items.Add(i);
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            Credit unCredit = new Credit(Convert.ToDouble(txtMontantFinance.Text), Convert.ToInt16(cbxDurée.Text), Convert.ToDouble(txtTauxAnnuel.Text));
            txtMensualite.Text = Convert.ToString(unCredit.getMensualite());
            if(Globales.lesCredits == null)
            {
                Globales.lesCredits = new List<Credit>();
            }
            
            Globales.lesCredits.Add(unCredit);
        }

        private void txtMontantFinance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListeCredit_Click(object sender, EventArgs e)
        {
            if (Globales.fenListeCredit == null)
            {
                Globales.fenListeCredit = new frmListeCredit();
            }
            Globales.fenListeCredit.Show();
            this.Close();
            
        }
    }
}
