
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
            this.lblMaRegion = new System.Windows.Forms.Label();
            this.lblMonApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdIntro
            // 
            this.cmdIntro.Location = new System.Drawing.Point(294, 289);
            this.cmdIntro.Name = "cmdIntro";
            this.cmdIntro.Size = new System.Drawing.Size(201, 29);
            this.cmdIntro.TabIndex = 0;
            this.cmdIntro.Text = "Nouveau Client";
            this.cmdIntro.UseVisualStyleBackColor = true;
            this.cmdIntro.Click += new System.EventHandler(this.cmdIntro_Click);
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
            // lblMonApp
            // 
            this.lblMonApp.AutoSize = true;
            this.lblMonApp.Location = new System.Drawing.Point(697, 47);
            this.lblMonApp.Name = "lblMonApp";
            this.lblMonApp.Size = new System.Drawing.Size(49, 17);
            this.lblMonApp.TabIndex = 3;
            this.lblMonApp.Text = "Arrass";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaRegion);
            this.Controls.Add(this.lblMonApp);
            this.Controls.Add(this.cmdIntro);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIntro;
        private System.Windows.Forms.Label lblMaRegion;
        private System.Windows.Forms.Label lblMonApp;
    }
}

