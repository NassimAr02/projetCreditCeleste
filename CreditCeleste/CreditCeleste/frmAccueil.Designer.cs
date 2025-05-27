
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
            // lblNomConcession
            // 
            this.lblNomConcession.AutoSize = true;
            this.lblNomConcession.Location = new System.Drawing.Point(315, 177);
            this.lblNomConcession.Name = "lblNomConcession";
            this.lblNomConcession.Size = new System.Drawing.Size(109, 16);
            this.lblNomConcession.TabIndex = 1;
            this.lblNomConcession.Text = "Nom concession";
            // 
            // lblNumRue
            // 
            this.lblNumRue.AutoSize = true;
            this.lblNumRue.Location = new System.Drawing.Point(315, 193);
            this.lblNumRue.Name = "lblNumRue";
            this.lblNumRue.Size = new System.Drawing.Size(58, 16);
            this.lblNumRue.TabIndex = 2;
            this.lblNumRue.Text = "Num rue";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(370, 193);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(107, 16);
            this.lblRue.TabIndex = 3;
            this.lblRue.Text = "Rue Concession";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(315, 209);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(43, 16);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "00000";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(364, 209);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(108, 16);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville Concession";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblNumRue);
            this.Controls.Add(this.lblNomConcession);
            this.Controls.Add(this.cmdIntro);
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
    }
}

