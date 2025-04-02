
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
            this.lblJmpl = new System.Windows.Forms.Label();
            this.cbxVendeur = new System.Windows.Forms.ComboBox();
            this.lblvendeur = new System.Windows.Forms.Label();
            this.lblNewV = new System.Windows.Forms.Label();
            this.txtNewV = new System.Windows.Forms.TextBox();
            this.gpbAgeV = new System.Windows.Forms.GroupBox();
            this.rdb5ans = new System.Windows.Forms.RadioButton();
            this.rdb3à5ans = new System.Windows.Forms.RadioButton();
            this.rdb3ans = new System.Windows.Forms.RadioButton();
            this.rdbNeuf = new System.Windows.Forms.RadioButton();
            this.lblAncienV = new System.Windows.Forms.Label();
            this.txtAncVhc = new System.Windows.Forms.TextBox();
            this.cmdSaisieBien = new System.Windows.Forms.Button();
            this.cmdVersBdd = new System.Windows.Forms.Button();
            this.cmdVersNouveauClient = new System.Windows.Forms.Button();
            this.gpbAgeV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomA
            // 
            this.lblNomA.AutoSize = true;
            this.lblNomA.Location = new System.Drawing.Point(650, 34);
            this.lblNomA.Name = "lblNomA";
            this.lblNomA.Size = new System.Drawing.Size(0, 17);
            this.lblNomA.TabIndex = 1;
            this.lblNomA.Click += new System.EventHandler(this.lblNomA_Click);
            // 
            // lblJmpl
            // 
            this.lblJmpl.AutoSize = true;
            this.lblJmpl.Location = new System.Drawing.Point(39, 34);
            this.lblJmpl.Name = "lblJmpl";
            this.lblJmpl.Size = new System.Drawing.Size(87, 17);
            this.lblJmpl.TabIndex = 2;
            this.lblJmpl.Text = "Je m\'appelle";
            // 
            // cbxVendeur
            // 
            this.cbxVendeur.FormattingEnabled = true;
            this.cbxVendeur.Location = new System.Drawing.Point(42, 90);
            this.cbxVendeur.Name = "cbxVendeur";
            this.cbxVendeur.Size = new System.Drawing.Size(121, 24);
            this.cbxVendeur.TabIndex = 9;
            this.cbxVendeur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblvendeur
            // 
            this.lblvendeur.AutoSize = true;
            this.lblvendeur.Location = new System.Drawing.Point(39, 70);
            this.lblvendeur.Name = "lblvendeur";
            this.lblvendeur.Size = new System.Drawing.Size(62, 17);
            this.lblvendeur.TabIndex = 10;
            this.lblvendeur.Text = "Vendeur";
            // 
            // lblNewV
            // 
            this.lblNewV.AutoSize = true;
            this.lblNewV.Location = new System.Drawing.Point(473, 34);
            this.lblNewV.Name = "lblNewV";
            this.lblNewV.Size = new System.Drawing.Size(158, 17);
            this.lblNewV.TabIndex = 11;
            this.lblNewV.Text = "Mon Nouveau Véhicule ";
            this.lblNewV.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNewV
            // 
            this.txtNewV.Location = new System.Drawing.Point(476, 61);
            this.txtNewV.Name = "txtNewV";
            this.txtNewV.Size = new System.Drawing.Size(100, 22);
            this.txtNewV.TabIndex = 12;
            // 
            // gpbAgeV
            // 
            this.gpbAgeV.Controls.Add(this.rdb5ans);
            this.gpbAgeV.Controls.Add(this.rdb3à5ans);
            this.gpbAgeV.Controls.Add(this.rdb3ans);
            this.gpbAgeV.Controls.Add(this.rdbNeuf);
            this.gpbAgeV.Location = new System.Drawing.Point(307, 214);
            this.gpbAgeV.Name = "gpbAgeV";
            this.gpbAgeV.Size = new System.Drawing.Size(241, 156);
            this.gpbAgeV.TabIndex = 13;
            this.gpbAgeV.TabStop = false;
            this.gpbAgeV.Text = "Age du véhicule";
            // 
            // rdb5ans
            // 
            this.rdb5ans.AutoSize = true;
            this.rdb5ans.Location = new System.Drawing.Point(23, 115);
            this.rdb5ans.Name = "rdb5ans";
            this.rdb5ans.Size = new System.Drawing.Size(177, 21);
            this.rdb5ans.TabIndex = 3;
            this.rdb5ans.TabStop = true;
            this.rdb5ans.Text = "Occasion 5 ans et plus ";
            this.rdb5ans.UseVisualStyleBackColor = true;
            // 
            // rdb3à5ans
            // 
            this.rdb3à5ans.AutoSize = true;
            this.rdb3à5ans.Location = new System.Drawing.Point(23, 88);
            this.rdb3à5ans.Name = "rdb3à5ans";
            this.rdb3à5ans.Size = new System.Drawing.Size(175, 21);
            this.rdb3à5ans.TabIndex = 2;
            this.rdb3à5ans.TabStop = true;
            this.rdb3à5ans.Text = "Occasion de 3 à 5 ans ";
            this.rdb3à5ans.UseVisualStyleBackColor = true;
            // 
            // rdb3ans
            // 
            this.rdb3ans.AutoSize = true;
            this.rdb3ans.Location = new System.Drawing.Point(23, 60);
            this.rdb3ans.Name = "rdb3ans";
            this.rdb3ans.Size = new System.Drawing.Size(160, 21);
            this.rdb3ans.TabIndex = 1;
            this.rdb3ans.TabStop = true;
            this.rdb3ans.Text = "Occasion - de 3 ans ";
            this.rdb3ans.UseVisualStyleBackColor = true;
            // 
            // rdbNeuf
            // 
            this.rdbNeuf.AutoSize = true;
            this.rdbNeuf.Location = new System.Drawing.Point(23, 33);
            this.rdbNeuf.Name = "rdbNeuf";
            this.rdbNeuf.Size = new System.Drawing.Size(59, 21);
            this.rdbNeuf.TabIndex = 0;
            this.rdbNeuf.TabStop = true;
            this.rdbNeuf.Text = "Neuf";
            this.rdbNeuf.UseVisualStyleBackColor = true;
            // 
            // lblAncienV
            // 
            this.lblAncienV.AutoSize = true;
            this.lblAncienV.Location = new System.Drawing.Point(637, 34);
            this.lblAncienV.Name = "lblAncienV";
            this.lblAncienV.Size = new System.Drawing.Size(140, 17);
            this.lblAncienV.TabIndex = 14;
            this.lblAncienV.Text = "Mon Ancien Vehicule";
            // 
            // txtAncVhc
            // 
            this.txtAncVhc.Location = new System.Drawing.Point(640, 61);
            this.txtAncVhc.Name = "txtAncVhc";
            this.txtAncVhc.Size = new System.Drawing.Size(100, 22);
            this.txtAncVhc.TabIndex = 15;
            // 
            // cmdSaisieBien
            // 
            this.cmdSaisieBien.Location = new System.Drawing.Point(347, 395);
            this.cmdSaisieBien.Name = "cmdSaisieBien";
            this.cmdSaisieBien.Size = new System.Drawing.Size(104, 30);
            this.cmdSaisieBien.TabIndex = 16;
            this.cmdSaisieBien.Text = "Voiture";
            this.cmdSaisieBien.UseVisualStyleBackColor = true;
            this.cmdSaisieBien.Click += new System.EventHandler(this.cmdSaisieBien_Click);
            // 
            // cmdVersBdd
            // 
            this.cmdVersBdd.Location = new System.Drawing.Point(476, 395);
            this.cmdVersBdd.Name = "cmdVersBdd";
            this.cmdVersBdd.Size = new System.Drawing.Size(100, 30);
            this.cmdVersBdd.TabIndex = 17;
            this.cmdVersBdd.Text = "Je valide";
            this.cmdVersBdd.UseVisualStyleBackColor = true;
            // 
            // cmdVersNouveauClient
            // 
            this.cmdVersNouveauClient.Location = new System.Drawing.Point(216, 395);
            this.cmdVersNouveauClient.Name = "cmdVersNouveauClient";
            this.cmdVersNouveauClient.Size = new System.Drawing.Size(104, 30);
            this.cmdVersNouveauClient.TabIndex = 18;
            this.cmdVersNouveauClient.Text = "Précédent";
            this.cmdVersNouveauClient.UseVisualStyleBackColor = true;
            // 
            // frmIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdVersNouveauClient);
            this.Controls.Add(this.cmdVersBdd);
            this.Controls.Add(this.cmdSaisieBien);
            this.Controls.Add(this.txtAncVhc);
            this.Controls.Add(this.lblAncienV);
            this.Controls.Add(this.gpbAgeV);
            this.Controls.Add(this.txtNewV);
            this.Controls.Add(this.lblNewV);
            this.Controls.Add(this.lblvendeur);
            this.Controls.Add(this.cbxVendeur);
            this.Controls.Add(this.lblJmpl);
            this.Controls.Add(this.lblNomA);
            this.Name = "frmIntroduction";
            this.Text = "frmIntroduction";
            this.Load += new System.EventHandler(this.frmIntroduction_Load);
            this.gpbAgeV.ResumeLayout(false);
            this.gpbAgeV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomA;
        private System.Windows.Forms.Label lblJmpl;
        private System.Windows.Forms.ComboBox cbxVendeur;
        private System.Windows.Forms.Label lblvendeur;
        private System.Windows.Forms.Label lblNewV;
        private System.Windows.Forms.TextBox txtNewV;
        private System.Windows.Forms.GroupBox gpbAgeV;
        private System.Windows.Forms.RadioButton rdb5ans;
        private System.Windows.Forms.RadioButton rdb3à5ans;
        private System.Windows.Forms.RadioButton rdb3ans;
        private System.Windows.Forms.RadioButton rdbNeuf;
        private System.Windows.Forms.Label lblAncienV;
        private System.Windows.Forms.TextBox txtAncVhc;
        private System.Windows.Forms.Button cmdSaisieBien;
        private System.Windows.Forms.Button cmdVersBdd;
        private System.Windows.Forms.Button cmdVersNouveauClient;
    }
}