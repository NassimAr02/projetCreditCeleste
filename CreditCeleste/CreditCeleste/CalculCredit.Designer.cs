
namespace CreditCeleste
{
    partial class frmCalculCredit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMontantFinance = new System.Windows.Forms.TextBox();
            this.txtTauxAnnuel = new System.Windows.Forms.MaskedTextBox();
            this.txtMensualite = new System.Windows.Forms.MaskedTextBox();
            this.cbxDurée = new System.Windows.Forms.ComboBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblTaux = new System.Windows.Forms.Label();
            this.lblMensualite = new System.Windows.Forms.Label();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnListeCredit = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMontantFinance
            // 
            this.txtMontantFinance.Location = new System.Drawing.Point(40, 48);
            this.txtMontantFinance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMontantFinance.Name = "txtMontantFinance";
            this.txtMontantFinance.Size = new System.Drawing.Size(92, 20);
            this.txtMontantFinance.TabIndex = 0;
            this.txtMontantFinance.TextChanged += new System.EventHandler(this.txtMontantFinance_TextChanged);
            // 
            // txtTauxAnnuel
            // 
            this.txtTauxAnnuel.Location = new System.Drawing.Point(40, 150);
            this.txtTauxAnnuel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTauxAnnuel.Name = "txtTauxAnnuel";
            this.txtTauxAnnuel.Size = new System.Drawing.Size(92, 20);
            this.txtTauxAnnuel.TabIndex = 1;
            // 
            // txtMensualite
            // 
            this.txtMensualite.Location = new System.Drawing.Point(40, 207);
            this.txtMensualite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.Size = new System.Drawing.Size(92, 20);
            this.txtMensualite.TabIndex = 2;
            // 
            // cbxDurée
            // 
            this.cbxDurée.FormattingEnabled = true;
            this.cbxDurée.Location = new System.Drawing.Point(40, 97);
            this.cbxDurée.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDurée.Name = "cbxDurée";
            this.cbxDurée.Size = new System.Drawing.Size(92, 21);
            this.cbxDurée.TabIndex = 3;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(38, 68);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(93, 13);
            this.lblMontant.TabIndex = 4;
            this.lblMontant.Text = "Montant Financé :";
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Location = new System.Drawing.Point(38, 126);
            this.lblDuree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(81, 13);
            this.lblDuree.TabIndex = 5;
            this.lblDuree.Text = "Durée en mois :";
            // 
            // lblTaux
            // 
            this.lblTaux.AutoSize = true;
            this.lblTaux.Location = new System.Drawing.Point(38, 179);
            this.lblTaux.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaux.Name = "lblTaux";
            this.lblTaux.Size = new System.Drawing.Size(73, 13);
            this.lblTaux.TabIndex = 6;
            this.lblTaux.Text = "Taux Annuel :";
            // 
            // lblMensualite
            // 
            this.lblMensualite.AutoSize = true;
            this.lblMensualite.Location = new System.Drawing.Point(38, 235);
            this.lblMensualite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensualite.Name = "lblMensualite";
            this.lblMensualite.Size = new System.Drawing.Size(64, 13);
            this.lblMensualite.TabIndex = 7;
            this.lblMensualite.Text = "Mensualité :";
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(330, 203);
            this.btnCalcul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(56, 24);
            this.btnCalcul.TabIndex = 9;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // btnListeCredit
            // 
            this.btnListeCredit.Location = new System.Drawing.Point(368, 249);
            this.btnListeCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListeCredit.Name = "btnListeCredit";
            this.btnListeCredit.Size = new System.Drawing.Size(80, 24);
            this.btnListeCredit.TabIndex = 10;
            this.btnListeCredit.Text = "Liste Crédit";
            this.btnListeCredit.UseVisualStyleBackColor = true;
            this.btnListeCredit.Click += new System.EventHandler(this.btnListeCredit_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(275, 250);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btnPrecedent.TabIndex = 11;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // frmCalculCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnListeCredit);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.lblMensualite);
            this.Controls.Add(this.lblTaux);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.cbxDurée);
            this.Controls.Add(this.txtMensualite);
            this.Controls.Add(this.txtTauxAnnuel);
            this.Controls.Add(this.txtMontantFinance);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCalculCredit";
            this.Text = "Calcul Crédit";
            this.Load += new System.EventHandler(this.frmCalculCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontantFinance;
        private System.Windows.Forms.MaskedTextBox txtTauxAnnuel;
        private System.Windows.Forms.MaskedTextBox txtMensualite;
        private System.Windows.Forms.ComboBox cbxDurée;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblTaux;
        private System.Windows.Forms.Label lblMensualite;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnListeCredit;
        private System.Windows.Forms.Button btnPrecedent;
    }
}