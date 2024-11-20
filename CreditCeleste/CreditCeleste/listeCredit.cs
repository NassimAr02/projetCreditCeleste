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
    public partial class frmListeCredit : Form
    {
        public frmListeCredit()
        {
            InitializeComponent();
        }

        private void listeCredit_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Credit credit in Globales.lesCredits)
            {

            }
        }
    }
}
