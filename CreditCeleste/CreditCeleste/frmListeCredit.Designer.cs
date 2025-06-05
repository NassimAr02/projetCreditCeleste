
namespace CreditCeleste
{
    partial class frmListeCredit
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
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lsbLesCredits = new System.Windows.Forms.ListBox();
            this.cmdInit = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(307, 266);
            this.btnEnregistre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(82, 30);
            this.btnEnregistre.TabIndex = 1;
            this.btnEnregistre.Text = "Enregistrer";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(34, 36);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(56, 30);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Accueil";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // lsbLesCredits
            // 
            this.lsbLesCredits.FormattingEnabled = true;
            this.lsbLesCredits.Location = new System.Drawing.Point(150, 81);
            this.lsbLesCredits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbLesCredits.Name = "lsbLesCredits";
            this.lsbLesCredits.Size = new System.Drawing.Size(276, 121);
            this.lsbLesCredits.TabIndex = 3;
            this.lsbLesCredits.SelectedIndexChanged += new System.EventHandler(this.lsbLesCredits_SelectedIndexChanged);
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(34, 81);
            this.cmdInit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(85, 30);
            this.cmdInit.TabIndex = 5;
            this.cmdInit.Text = "Effacer la liste";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(478, 36);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(93, 23);
            this.btnDeconnexion.TabIndex = 7;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(185, 266);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(82, 30);
            this.btnPrecedent.TabIndex = 8;
            this.btnPrecedent.Text = "Précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // frmListeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.lsbLesCredits);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEnregistre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListeCredit";
            this.Text = "listeCredit";
            this.Load += new System.EventHandler(this.listeCredit_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnregistre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListBox lsbLesCredits;
        private System.Windows.Forms.Button cmdInit;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnPrecedent;
    }
}