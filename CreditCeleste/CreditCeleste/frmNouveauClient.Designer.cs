
namespace CreditCeleste
{
    partial class frmNouveauClient
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
            this.cboCiv = new System.Windows.Forms.ComboBox();
            this.lblCiv = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomJeuneF = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomJeuneF = new System.Windows.Forms.TextBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.txtCodePostal = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRevenu = new System.Windows.Forms.TextBox();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.dtpDateN = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cboCiv
            // 
            this.cboCiv.FormattingEnabled = true;
            this.cboCiv.Items.AddRange(new object[] {
            "M.",
            "Mme."});
            this.cboCiv.Location = new System.Drawing.Point(41, 67);
            this.cboCiv.Name = "cboCiv";
            this.cboCiv.Size = new System.Drawing.Size(121, 24);
            this.cboCiv.TabIndex = 1;
            // 
            // lblCiv
            // 
            this.lblCiv.AutoSize = true;
            this.lblCiv.Location = new System.Drawing.Point(38, 47);
            this.lblCiv.Name = "lblCiv";
            this.lblCiv.Size = new System.Drawing.Size(48, 17);
            this.lblCiv.TabIndex = 5;
            this.lblCiv.Text = "Civilité";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(38, 103);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(41, 123);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 8;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(38, 217);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 9;
            this.lblPrenom.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(41, 237);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 22);
            this.txtPrenom.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Adresse";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Numéro de téléphone";
            // 
            // lblNomJeuneF
            // 
            this.lblNomJeuneF.AutoSize = true;
            this.lblNomJeuneF.Location = new System.Drawing.Point(40, 157);
            this.lblNomJeuneF.Name = "lblNomJeuneF";
            this.lblNomJeuneF.Size = new System.Drawing.Size(109, 17);
            this.lblNomJeuneF.TabIndex = 15;
            this.lblNomJeuneF.Text = "Nom Jeune Fille";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Code Postal";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ville";
            // 
            // txtNomJeuneF
            // 
            this.txtNomJeuneF.Location = new System.Drawing.Point(41, 177);
            this.txtNomJeuneF.Name = "txtNomJeuneF";
            this.txtNomJeuneF.Size = new System.Drawing.Size(100, 22);
            this.txtNomJeuneF.TabIndex = 18;
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(216, 177);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(100, 22);
            this.txtNumTel.TabIndex = 19;
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(407, 67);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(100, 22);
            this.txtProfession.TabIndex = 20;
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Location = new System.Drawing.Point(216, 67);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(100, 22);
            this.txtCodePostal.TabIndex = 21;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(216, 123);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 22);
            this.txtVille.TabIndex = 22;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(41, 298);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 22);
            this.txtAdresse.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Profession";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Revenu annuel";
            // 
            // txtRevenu
            // 
            this.txtRevenu.Location = new System.Drawing.Point(407, 123);
            this.txtRevenu.Name = "txtRevenu";
            this.txtRevenu.Size = new System.Drawing.Size(100, 22);
            this.txtRevenu.TabIndex = 27;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(726, 421);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(107, 32);
            this.btnConfirmer.TabIndex = 28;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(607, 421);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(89, 32);
            this.btnPrecedent.TabIndex = 29;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // dtpDateN
            // 
            this.dtpDateN.Location = new System.Drawing.Point(216, 240);
            this.dtpDateN.Name = "dtpDateN";
            this.dtpDateN.Size = new System.Drawing.Size(200, 22);
            this.dtpDateN.TabIndex = 31;
            // 
            // frmNouveauClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 527);
            this.Controls.Add(this.dtpDateN);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.txtRevenu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.txtProfession);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.txtNomJeuneF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNomJeuneF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblCiv);
            this.Controls.Add(this.cboCiv);
            this.Name = "frmNouveauClient";
            this.Text = "frmNouveauClient";
            this.Load += new System.EventHandler(this.frmNouveauClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCiv;
        private System.Windows.Forms.Label lblCiv;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomJeuneF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomJeuneF;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.TextBox txtCodePostal;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRevenu;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.DateTimePicker dtpDateN;
    }
}