
namespace CreditCeleste
{
    partial class frmIntroduction
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
            this.lblNomA = new System.Windows.Forms.Label();
            this.lblvendeur = new System.Windows.Forms.Label();
            this.lblAncienV = new System.Windows.Forms.Label();
            this.txtAncVhc = new System.Windows.Forms.TextBox();
            this.cmdSaisieBien = new System.Windows.Forms.Button();
            this.cmdVersNouveauClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumImmat = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.dtpImmat = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblNomA
            // 
            this.lblNomA.AutoSize = true;
            this.lblNomA.Location = new System.Drawing.Point(85, 28);
            this.lblNomA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomA.Name = "lblNomA";
            this.lblNomA.Size = new System.Drawing.Size(0, 13);
            this.lblNomA.TabIndex = 1;
            this.lblNomA.Click += new System.EventHandler(this.lblNomA_Click);
            // 
            // lblvendeur
            // 
            this.lblvendeur.AutoSize = true;
            this.lblvendeur.Location = new System.Drawing.Point(28, 28);
            this.lblvendeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvendeur.Name = "lblvendeur";
            this.lblvendeur.Size = new System.Drawing.Size(53, 13);
            this.lblvendeur.TabIndex = 10;
            this.lblvendeur.Text = "Vendeur :";
            // 
            // lblAncienV
            // 
            this.lblAncienV.AutoSize = true;
            this.lblAncienV.Location = new System.Drawing.Point(38, 100);
            this.lblAncienV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAncienV.Name = "lblAncienV";
            this.lblAncienV.Size = new System.Drawing.Size(121, 13);
            this.lblAncienV.TabIndex = 14;
            this.lblAncienV.Text = "Libellé Ancienne Voiture";
            // 
            // txtAncVhc
            // 
            this.txtAncVhc.Location = new System.Drawing.Point(40, 115);
            this.txtAncVhc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAncVhc.Name = "txtAncVhc";
            this.txtAncVhc.Size = new System.Drawing.Size(133, 20);
            this.txtAncVhc.TabIndex = 1;
            // 
            // cmdSaisieBien
            // 
            this.cmdSaisieBien.Location = new System.Drawing.Point(333, 321);
            this.cmdSaisieBien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSaisieBien.Name = "cmdSaisieBien";
            this.cmdSaisieBien.Size = new System.Drawing.Size(99, 24);
            this.cmdSaisieBien.TabIndex = 16;
            this.cmdSaisieBien.Text = "Nouvelle Voiture";
            this.cmdSaisieBien.UseVisualStyleBackColor = true;
            this.cmdSaisieBien.Click += new System.EventHandler(this.cmdSaisieBien_Click);
            // 
            // cmdVersNouveauClient
            // 
            this.cmdVersNouveauClient.Location = new System.Drawing.Point(230, 321);
            this.cmdVersNouveauClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdVersNouveauClient.Name = "cmdVersNouveauClient";
            this.cmdVersNouveauClient.Size = new System.Drawing.Size(78, 24);
            this.cmdVersNouveauClient.TabIndex = 18;
            this.cmdVersNouveauClient.Text = "Précédent";
            this.cmdVersNouveauClient.UseVisualStyleBackColor = true;
            this.cmdVersNouveauClient.Click += new System.EventHandler(this.cmdVersNouveauClient_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Numéro de série";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Numéro immatriculation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date de première immatriculation";
            // 
            // txtNumImmat
            // 
            this.txtNumImmat.Location = new System.Drawing.Point(40, 162);
            this.txtNumImmat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumImmat.Name = "txtNumImmat";
            this.txtNumImmat.Size = new System.Drawing.Size(133, 20);
            this.txtNumImmat.TabIndex = 3;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Location = new System.Drawing.Point(230, 115);
            this.txtNumSerie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(112, 20);
            this.txtNumSerie.TabIndex = 2;
            // 
            // dtpImmat
            // 
            this.dtpImmat.Location = new System.Drawing.Point(230, 162);
            this.dtpImmat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpImmat.Name = "dtpImmat";
            this.dtpImmat.Size = new System.Drawing.Size(151, 20);
            this.dtpImmat.TabIndex = 4;
            // 
            // frmIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dtpImmat);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtNumImmat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdVersNouveauClient);
            this.Controls.Add(this.cmdSaisieBien);
            this.Controls.Add(this.txtAncVhc);
            this.Controls.Add(this.lblAncienV);
            this.Controls.Add(this.lblvendeur);
            this.Controls.Add(this.lblNomA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmIntroduction";
            this.Text = "frmIntroduction";
            this.Load += new System.EventHandler(this.frmIntroduction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomA;
        private System.Windows.Forms.Label lblvendeur;
        private System.Windows.Forms.Label lblAncienV;
        private System.Windows.Forms.TextBox txtAncVhc;
        private System.Windows.Forms.Button cmdSaisieBien;
        private System.Windows.Forms.Button cmdVersNouveauClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumImmat;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.DateTimePicker dtpImmat;
    }
}