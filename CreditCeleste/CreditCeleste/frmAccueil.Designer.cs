
namespace CreditCeleste
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdIntro = new System.Windows.Forms.Button();
            this.lblNomConcession = new System.Windows.Forms.Label();
            this.lblNumRue = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdIntro
            // 
            this.cmdIntro.Location = new System.Drawing.Point(220, 235);
            this.cmdIntro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdIntro.Name = "cmdIntro";
            this.cmdIntro.Size = new System.Drawing.Size(151, 24);
            this.cmdIntro.TabIndex = 0;
            this.cmdIntro.Text = "Nouveau Client";
            this.cmdIntro.UseVisualStyleBackColor = true;
            this.cmdIntro.Click += new System.EventHandler(this.cmdIntro_Click);
            // 
            // lblNomConcession
            // 
            this.lblNomConcession.AutoSize = true;
            this.lblNomConcession.Location = new System.Drawing.Point(236, 144);
            this.lblNomConcession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomConcession.Name = "lblNomConcession";
            this.lblNomConcession.Size = new System.Drawing.Size(86, 13);
            this.lblNomConcession.TabIndex = 1;
            this.lblNomConcession.Text = "Nom concession";
            // 
            // lblNumRue
            // 
            this.lblNumRue.AutoSize = true;
            this.lblNumRue.Location = new System.Drawing.Point(236, 157);
            this.lblNumRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumRue.Name = "lblNumRue";
            this.lblNumRue.Size = new System.Drawing.Size(47, 13);
            this.lblNumRue.TabIndex = 2;
            this.lblNumRue.Text = "Num rue";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(278, 157);
            this.lblRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(85, 13);
            this.lblRue.TabIndex = 3;
            this.lblRue.Text = "Rue Concession";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(236, 170);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(37, 13);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "00000";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(273, 170);
            this.lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(84, 13);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville Concession";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(44, 43);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(93, 23);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblNumRue);
            this.Controls.Add(this.lblNomConcession);
            this.Controls.Add(this.cmdIntro);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIntro;
        private System.Windows.Forms.Label lblNomConcession;
        private System.Windows.Forms.Label lblNumRue;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}

