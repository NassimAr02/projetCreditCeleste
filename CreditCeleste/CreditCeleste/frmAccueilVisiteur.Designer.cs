
namespace CreditCeleste
{
    partial class frmAccueilVisiteur
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
            this.lsbFactureNon = new System.Windows.Forms.ListBox();
            this.btnNouvVisite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbFactureOui = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbFactureNon
            // 
            this.lsbFactureNon.FormattingEnabled = true;
            this.lsbFactureNon.ItemHeight = 20;
            this.lsbFactureNon.Location = new System.Drawing.Point(41, 113);
            this.lsbFactureNon.Name = "lsbFactureNon";
            this.lsbFactureNon.Size = new System.Drawing.Size(1000, 224);
            this.lsbFactureNon.TabIndex = 0;
            this.lsbFactureNon.Tag = "";
            this.lsbFactureNon.SelectedIndexChanged += new System.EventHandler(this.lsbMesVisites_SelectedIndexChanged);
            // 
            // btnNouvVisite
            // 
            this.btnNouvVisite.Location = new System.Drawing.Point(1126, 359);
            this.btnNouvVisite.Name = "btnNouvVisite";
            this.btnNouvVisite.Size = new System.Drawing.Size(135, 40);
            this.btnNouvVisite.TabIndex = 1;
            this.btnNouvVisite.Text = "Nouvelle Visite";
            this.btnNouvVisite.UseVisualStyleBackColor = true;
            this.btnNouvVisite.Click += new System.EventHandler(this.btnNouvVisite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes factures";
            // 
            // lsbFactureOui
            // 
            this.lsbFactureOui.FormattingEnabled = true;
            this.lsbFactureOui.ItemHeight = 20;
            this.lsbFactureOui.Location = new System.Drawing.Point(41, 426);
            this.lsbFactureOui.Name = "lsbFactureOui";
            this.lsbFactureOui.Size = new System.Drawing.Size(1000, 224);
            this.lsbFactureOui.TabIndex = 3;
            this.lsbFactureOui.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Non remboursées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remboursées";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Location = new System.Drawing.Point(1133, 73);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(128, 35);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // frmAccueilVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 794);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbFactureOui);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNouvVisite);
            this.Controls.Add(this.lsbFactureNon);
            this.Name = "frmAccueilVisiteur";
            this.Text = "Accueil Visiteur";
            this.Load += new System.EventHandler(this.frmAccueilVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFactureNon;
        private System.Windows.Forms.Button btnNouvVisite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbFactureOui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeconnexion;
    }
}