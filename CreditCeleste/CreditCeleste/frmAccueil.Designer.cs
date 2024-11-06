
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
            this.cmdEtude = new System.Windows.Forms.Button();
            this.cmdRelance = new System.Windows.Forms.Button();
            this.lblMonApp = new System.Windows.Forms.Label();
            this.lblMaRegion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdIntro
            // 
            this.cmdIntro.Location = new System.Drawing.Point(280, 343);
            this.cmdIntro.Name = "cmdIntro";
            this.cmdIntro.Size = new System.Drawing.Size(98, 29);
            this.cmdIntro.TabIndex = 0;
            this.cmdIntro.Text = "Introduction";
            this.cmdIntro.UseVisualStyleBackColor = true;
            this.cmdIntro.Click += new System.EventHandler(this.cmdIntro_Click);
            // 
            // cmdEtude
            // 
            this.cmdEtude.Location = new System.Drawing.Point(384, 343);
            this.cmdEtude.Name = "cmdEtude";
            this.cmdEtude.Size = new System.Drawing.Size(98, 29);
            this.cmdEtude.TabIndex = 1;
            this.cmdEtude.Text = "Etude";
            this.cmdEtude.UseVisualStyleBackColor = true;
            this.cmdEtude.Click += new System.EventHandler(this.cmdEtude_Click);
            // 
            // cmdRelance
            // 
            this.cmdRelance.Location = new System.Drawing.Point(488, 343);
            this.cmdRelance.Name = "cmdRelance";
            this.cmdRelance.Size = new System.Drawing.Size(98, 29);
            this.cmdRelance.TabIndex = 2;
            this.cmdRelance.Text = "&Relance";
            this.cmdRelance.UseVisualStyleBackColor = true;
            // 
            // lblMonApp
            // 
            this.lblMonApp.AutoSize = true;
            this.lblMonApp.Location = new System.Drawing.Point(697, 47);
            this.lblMonApp.Name = "lblMonApp";
            this.lblMonApp.Size = new System.Drawing.Size(49, 17);
            this.lblMonApp.TabIndex = 3;
            this.lblMonApp.Text = "Arrass";
            // 
            // lblMaRegion
            // 
            this.lblMaRegion.AutoSize = true;
            this.lblMaRegion.Location = new System.Drawing.Point(31, 47);
            this.lblMaRegion.Name = "lblMaRegion";
            this.lblMaRegion.Size = new System.Drawing.Size(16, 17);
            this.lblMaRegion.TabIndex = 4;
            this.lblMaRegion.Text = "a";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaRegion);
            this.Controls.Add(this.lblMonApp);
            this.Controls.Add(this.cmdRelance);
            this.Controls.Add(this.cmdEtude);
            this.Controls.Add(this.cmdIntro);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIntro;
        private System.Windows.Forms.Button cmdEtude;
        private System.Windows.Forms.Button cmdRelance;
        private System.Windows.Forms.Label lblMonApp;
        private System.Windows.Forms.Label lblMaRegion;
    }
}

