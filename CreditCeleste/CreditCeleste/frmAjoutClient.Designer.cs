
namespace CreditCeleste
{
    partial class frmAjoutClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPrenomClient = new System.Windows.Forms.Label();
            this.lblCiv = new System.Windows.Forms.Label();
            this.cboCiv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtNomJeuneFille = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRevenuA = new System.Windows.Forms.TextBox();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom ";
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(71, 117);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(121, 22);
            this.txtNomClient.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 10;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.AutoSize = true;
            this.txtPrenomClient.Location = new System.Drawing.Point(68, 206);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(61, 17);
            this.txtPrenomClient.TabIndex = 9;
            this.txtPrenomClient.Text = "Prenom ";
            // 
            // lblCiv
            // 
            this.lblCiv.AutoSize = true;
            this.lblCiv.Location = new System.Drawing.Point(68, 43);
            this.lblCiv.Name = "lblCiv";
            this.lblCiv.Size = new System.Drawing.Size(48, 17);
            this.lblCiv.TabIndex = 12;
            this.lblCiv.Text = "Civilité";
            // 
            // cboCiv
            // 
            this.cboCiv.FormattingEnabled = true;
            this.cboCiv.Items.AddRange(new object[] {
            "M.",
            "Mme."});
            this.cboCiv.Location = new System.Drawing.Point(71, 63);
            this.cboCiv.Name = "cboCiv";
            this.cboCiv.Size = new System.Drawing.Size(121, 24);
            this.cboCiv.TabIndex = 11;
            this.cboCiv.SelectedIndexChanged += new System.EventHandler(this.cboCiv_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rue";
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(439, 120);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(278, 22);
            this.txtRue.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Numéro de rue";
            // 
            // txtNumRue
            // 
            this.txtNumRue.Location = new System.Drawing.Point(439, 65);
            this.txtNumRue.Name = "txtNumRue";
            this.txtNumRue.Size = new System.Drawing.Size(100, 22);
            this.txtNumRue.TabIndex = 22;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(439, 171);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 22);
            this.txtCP.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Code Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ville";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(583, 171);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(134, 22);
            this.txtVille.TabIndex = 26;
            // 
            // txtNomJeuneFille
            // 
            this.txtNomJeuneFille.Location = new System.Drawing.Point(71, 171);
            this.txtNomJeuneFille.Name = "txtNomJeuneFille";
            this.txtNomJeuneFille.Size = new System.Drawing.Size(121, 22);
            this.txtNomJeuneFille.TabIndex = 29;
            this.txtNomJeuneFille.TextChanged += new System.EventHandler(this.txtNomJeuneFille_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Nom de jeune fille";
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(73, 283);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(200, 22);
            this.dtpDateNaissance.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "Date de Naissance";
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(439, 226);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(177, 22);
            this.txtProfession.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Profession";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Revenu annuel";
            // 
            // txtRevenuA
            // 
            this.txtRevenuA.Location = new System.Drawing.Point(439, 283);
            this.txtRevenuA.Name = "txtRevenuA";
            this.txtRevenuA.Size = new System.Drawing.Size(177, 22);
            this.txtRevenuA.TabIndex = 34;
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(277, 361);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(107, 36);
            this.btnPrecedent.TabIndex = 36;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(406, 361);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(107, 36);
            this.btnSuivant.TabIndex = 37;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // frmAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRevenuA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProfession);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.txtNomJeuneFille);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumRue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRue);
            this.Controls.Add(this.lblCiv);
            this.Controls.Add(this.cboCiv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPrenomClient);
            this.Controls.Add(this.txtNomClient);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutClient";
            this.Text = "Ajout d\'un Client";
            this.Load += new System.EventHandler(this.frmAjoutClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtPrenomClient;
        private System.Windows.Forms.Label lblCiv;
        private System.Windows.Forms.ComboBox cboCiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumRue;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtNomJeuneFille;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRevenuA;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
    }
}