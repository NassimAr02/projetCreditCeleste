
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
            this.cboCiv = new System.Windows.Forms.ComboBox();
            this.lblNomA = new System.Windows.Forms.Label();
            this.lblJmpl = new System.Windows.Forms.Label();
            this.lblCiv = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
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
            this.ccmdEnregistre = new System.Windows.Forms.Button();
            this.cmdSaisieBien = new System.Windows.Forms.Button();
            this.cmdVersBdd = new System.Windows.Forms.Button();
            this.gpbAgeV.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCiv
            // 
            this.cboCiv.FormattingEnabled = true;
            this.cboCiv.Items.AddRange(new object[] {
            "M.",
            "Mme."});
            this.cboCiv.Location = new System.Drawing.Point(42, 64);
            this.cboCiv.Name = "cboCiv";
            this.cboCiv.Size = new System.Drawing.Size(121, 24);
            this.cboCiv.TabIndex = 0;
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
            // lblCiv
            // 
            this.lblCiv.AutoSize = true;
            this.lblCiv.Location = new System.Drawing.Point(39, 91);
            this.lblCiv.Name = "lblCiv";
            this.lblCiv.Size = new System.Drawing.Size(48, 17);
            this.lblCiv.TabIndex = 4;
            this.lblCiv.Text = "Civilité";
            this.lblCiv.Click += new System.EventHandler(this.lblCiv_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(39, 137);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom";
            this.lblNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(42, 157);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 22);
            this.txtNom.TabIndex = 5;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(39, 214);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 8;
            this.lblPrenom.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(42, 234);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 22);
            this.txtPrenom.TabIndex = 7;
            // 
            // cbxVendeur
            // 
            this.cbxVendeur.FormattingEnabled = true;
            this.cbxVendeur.Location = new System.Drawing.Point(42, 315);
            this.cbxVendeur.Name = "cbxVendeur";
            this.cbxVendeur.Size = new System.Drawing.Size(121, 24);
            this.cbxVendeur.TabIndex = 9;
            this.cbxVendeur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblvendeur
            // 
            this.lblvendeur.AutoSize = true;
            this.lblvendeur.Location = new System.Drawing.Point(39, 295);
            this.lblvendeur.Name = "lblvendeur";
            this.lblvendeur.Size = new System.Drawing.Size(62, 17);
            this.lblvendeur.TabIndex = 10;
            this.lblvendeur.Text = "Vendeur";
            // 
            // lblNewV
            // 
            this.lblNewV.AutoSize = true;
            this.lblNewV.Location = new System.Drawing.Point(327, 64);
            this.lblNewV.Name = "lblNewV";
            this.lblNewV.Size = new System.Drawing.Size(158, 17);
            this.lblNewV.TabIndex = 11;
            this.lblNewV.Text = "Mon Nouveau Véhicule ";
            this.lblNewV.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNewV
            // 
            this.txtNewV.Location = new System.Drawing.Point(330, 91);
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
            this.lblAncienV.Location = new System.Drawing.Point(628, 64);
            this.lblAncienV.Name = "lblAncienV";
            this.lblAncienV.Size = new System.Drawing.Size(140, 17);
            this.lblAncienV.TabIndex = 14;
            this.lblAncienV.Text = "Mon Ancien Vehicule";
            // 
            // txtAncVhc
            // 
            this.txtAncVhc.Location = new System.Drawing.Point(631, 91);
            this.txtAncVhc.Name = "txtAncVhc";
            this.txtAncVhc.Size = new System.Drawing.Size(100, 22);
            this.txtAncVhc.TabIndex = 15;
            // 
            // ccmdEnregistre
            // 
            this.ccmdEnregistre.Location = new System.Drawing.Point(218, 395);
            this.ccmdEnregistre.Name = "ccmdEnregistre";
            this.ccmdEnregistre.Size = new System.Drawing.Size(104, 30);
            this.ccmdEnregistre.TabIndex = 4;
            this.ccmdEnregistre.Text = "J\'enregistre";
            this.ccmdEnregistre.UseVisualStyleBackColor = true;
            this.ccmdEnregistre.Click += new System.EventHandler(this.ccmdEnregistre_Click);
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
            this.cmdVersBdd.Click += new System.EventHandler(this.cmdVersBdd_Click);
            // 
            // frmIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdVersBdd);
            this.Controls.Add(this.cmdSaisieBien);
            this.Controls.Add(this.ccmdEnregistre);
            this.Controls.Add(this.txtAncVhc);
            this.Controls.Add(this.lblAncienV);
            this.Controls.Add(this.gpbAgeV);
            this.Controls.Add(this.txtNewV);
            this.Controls.Add(this.lblNewV);
            this.Controls.Add(this.lblvendeur);
            this.Controls.Add(this.cbxVendeur);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblCiv);
            this.Controls.Add(this.lblJmpl);
            this.Controls.Add(this.lblNomA);
            this.Controls.Add(this.cboCiv);
            this.Name = "frmIntroduction";
            this.Text = "frmIntroduction";
            this.Load += new System.EventHandler(this.frmIntroduction_Load);
            this.gpbAgeV.ResumeLayout(false);
            this.gpbAgeV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCiv;
        private System.Windows.Forms.Label lblNomA;
        private System.Windows.Forms.Label lblJmpl;
        private System.Windows.Forms.Label lblCiv;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
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
        private System.Windows.Forms.Button ccmdEnregistre;
        private System.Windows.Forms.Button cmdSaisieBien;
        private System.Windows.Forms.Button cmdVersBdd;
    }
}