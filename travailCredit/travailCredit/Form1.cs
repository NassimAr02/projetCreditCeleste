using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreditA;


namespace travailCredit
{
    public partial class frmCredit : Form
    {
        public frmCredit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmCredit_Load(object sender, EventArgs e)
        {
            int i;
            for(i=1; i<180; i++)
            {
                cbxDurée.Items.Add(i);
            }
        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {
            // Utilisation d'un objet Crédit

            Credit unCredit = new Credit(Convert.ToDouble(txtMontantFinancé.Text), Convert.ToDouble(cbxDurée.Text), Convert.ToDouble(txtTauxAnnuel.Text));
            txtMensualite.Text = Convert.ToString(unCredit.getMensualite());

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
