
namespace CreditCeleste
{
    partial class frmVisiteur
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
            this.dateDepartPicker = new System.Windows.Forms.DateTimePicker();
            this.cmdSuivant = new System.Windows.Forms.Button();
            this.lblCollaborateur = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateRetourPicker = new System.Windows.Forms.DateTimePicker();
            this.cbxConcession = new System.Windows.Forms.ComboBox();
            this.cboConcession = new System.Windows.Forms.Label();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.gbxVoiturePerso = new System.Windows.Forms.GroupBox();
            this.radioBtnNon = new System.Windows.Forms.RadioButton();
            this.radioBtnOui = new System.Windows.Forms.RadioButton();
            this.gbxVoiturePerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateDepartPicker
            // 
            this.dateDepartPicker.Location = new System.Drawing.Point(180, 222);
            this.dateDepartPicker.Name = "dateDepartPicker";
            this.dateDepartPicker.Size = new System.Drawing.Size(200, 26);
            this.dateDepartPicker.TabIndex = 28;
            // 
            // cmdSuivant
            // 
            this.cmdSuivant.Location = new System.Drawing.Point(481, 233);
            this.cmdSuivant.Name = "cmdSuivant";
            this.cmdSuivant.Size = new System.Drawing.Size(90, 32);
            this.cmdSuivant.TabIndex = 27;
            this.cmdSuivant.Text = "Suivant";
            this.cmdSuivant.UseVisualStyleBackColor = true;
            this.cmdSuivant.Click += new System.EventHandler(this.cmdSuivant_Click);
            // 
            // lblCollaborateur
            // 
            this.lblCollaborateur.AutoSize = true;
            this.lblCollaborateur.Location = new System.Drawing.Point(40, 47);
            this.lblCollaborateur.Name = "lblCollaborateur";
            this.lblCollaborateur.Size = new System.Drawing.Size(138, 20);
            this.lblCollaborateur.TabIndex = 20;
            this.lblCollaborateur.Text = "Nom collaborateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date de départ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Date de retour :";
            // 
            // dateRetourPicker
            // 
            this.dateRetourPicker.Location = new System.Drawing.Point(180, 289);
            this.dateRetourPicker.Name = "dateRetourPicker";
            this.dateRetourPicker.Size = new System.Drawing.Size(200, 26);
            this.dateRetourPicker.TabIndex = 31;
            // 
            // cbxConcession
            // 
            this.cbxConcession.FormattingEnabled = true;
            this.cbxConcession.Location = new System.Drawing.Point(180, 147);
            this.cbxConcession.Name = "cbxConcession";
            this.cbxConcession.Size = new System.Drawing.Size(200, 28);
            this.cbxConcession.TabIndex = 34;
            // 
            // cboConcession
            // 
            this.cboConcession.AutoSize = true;
            this.cboConcession.Location = new System.Drawing.Point(40, 155);
            this.cboConcession.Name = "cboConcession";
            this.cboConcession.Size = new System.Drawing.Size(92, 20);
            this.cboConcession.TabIndex = 35;
            this.cboConcession.Text = "Concession";
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(481, 176);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(90, 33);
            this.btnAccueil.TabIndex = 36;
            this.btnAccueil.Text = "Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // gbxVoiturePerso
            // 
            this.gbxVoiturePerso.Controls.Add(this.radioBtnNon);
            this.gbxVoiturePerso.Controls.Add(this.radioBtnOui);
            this.gbxVoiturePerso.Location = new System.Drawing.Point(44, 363);
            this.gbxVoiturePerso.Name = "gbxVoiturePerso";
            this.gbxVoiturePerso.Size = new System.Drawing.Size(233, 135);
            this.gbxVoiturePerso.TabIndex = 37;
            this.gbxVoiturePerso.TabStop = false;
            this.gbxVoiturePerso.Text = "Voiture personnelle";
            // 
            // radioBtnNon
            // 
            this.radioBtnNon.AutoSize = true;
            this.radioBtnNon.Location = new System.Drawing.Point(7, 81);
            this.radioBtnNon.Name = "radioBtnNon";
            this.radioBtnNon.Size = new System.Drawing.Size(63, 24);
            this.radioBtnNon.TabIndex = 1;
            this.radioBtnNon.TabStop = true;
            this.radioBtnNon.Text = "Non";
            this.radioBtnNon.UseVisualStyleBackColor = true;
            // 
            // radioBtnOui
            // 
            this.radioBtnOui.AutoSize = true;
            this.radioBtnOui.Location = new System.Drawing.Point(6, 35);
            this.radioBtnOui.Name = "radioBtnOui";
            this.radioBtnOui.Size = new System.Drawing.Size(58, 24);
            this.radioBtnOui.TabIndex = 0;
            this.radioBtnOui.TabStop = true;
            this.radioBtnOui.Text = "Oui";
            this.radioBtnOui.UseVisualStyleBackColor = true;
            // 
            // frmVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.gbxVoiturePerso);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.cboConcession);
            this.Controls.Add(this.cbxConcession);
            this.Controls.Add(this.dateRetourPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateDepartPicker);
            this.Controls.Add(this.cmdSuivant);
            this.Controls.Add(this.lblCollaborateur);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVisiteur";
            this.Text = "Visiteur";
            this.Load += new System.EventHandler(this.frmVisiteur_Load);
            this.gbxVoiturePerso.ResumeLayout(false);
            this.gbxVoiturePerso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDepartPicker;
        private System.Windows.Forms.Button cmdSuivant;
        private System.Windows.Forms.Label lblCollaborateur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateRetourPicker;
        private System.Windows.Forms.ComboBox cbxConcession;
        private System.Windows.Forms.Label cboConcession;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.GroupBox gbxVoiturePerso;
        private System.Windows.Forms.RadioButton radioBtnNon;
        private System.Windows.Forms.RadioButton radioBtnOui;
    }
}