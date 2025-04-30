
namespace CreditCeleste
{
    partial class frmSaisie
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
            this.dateFacture = new System.Windows.Forms.DateTimePicker();
            this.cmdEnvoyer = new System.Windows.Forms.Button();
            this.txtFraisEssence = new System.Windows.Forms.TextBox();
            this.txtFraisHotel = new System.Windows.Forms.TextBox();
            this.txtFraisRepas = new System.Windows.Forms.TextBox();
            this.lblFraisEssence = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFraisRepas = new System.Windows.Forms.Label();
            this.lblCollaborateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateFacture
            // 
            this.dateFacture.Location = new System.Drawing.Point(554, 63);
            this.dateFacture.Name = "dateFacture";
            this.dateFacture.Size = new System.Drawing.Size(200, 26);
            this.dateFacture.TabIndex = 19;
            // 
            // cmdEnvoyer
            // 
            this.cmdEnvoyer.Location = new System.Drawing.Point(584, 368);
            this.cmdEnvoyer.Name = "cmdEnvoyer";
            this.cmdEnvoyer.Size = new System.Drawing.Size(90, 32);
            this.cmdEnvoyer.TabIndex = 18;
            this.cmdEnvoyer.Text = "Envoyer";
            this.cmdEnvoyer.UseVisualStyleBackColor = true;
            this.cmdEnvoyer.Click += new System.EventHandler(this.cmdEnvoyer_Click);
            // 
            // txtFraisEssence
            // 
            this.txtFraisEssence.Location = new System.Drawing.Point(186, 297);
            this.txtFraisEssence.Name = "txtFraisEssence";
            this.txtFraisEssence.Size = new System.Drawing.Size(109, 26);
            this.txtFraisEssence.TabIndex = 17;
            // 
            // txtFraisHotel
            // 
            this.txtFraisHotel.Location = new System.Drawing.Point(186, 208);
            this.txtFraisHotel.Name = "txtFraisHotel";
            this.txtFraisHotel.Size = new System.Drawing.Size(109, 26);
            this.txtFraisHotel.TabIndex = 16;
            // 
            // txtFraisRepas
            // 
            this.txtFraisRepas.Location = new System.Drawing.Point(186, 130);
            this.txtFraisRepas.Name = "txtFraisRepas";
            this.txtFraisRepas.Size = new System.Drawing.Size(109, 26);
            this.txtFraisRepas.TabIndex = 15;
            // 
            // lblFraisEssence
            // 
            this.lblFraisEssence.AutoSize = true;
            this.lblFraisEssence.Location = new System.Drawing.Point(47, 297);
            this.lblFraisEssence.Name = "lblFraisEssence";
            this.lblFraisEssence.Size = new System.Drawing.Size(108, 20);
            this.lblFraisEssence.TabIndex = 14;
            this.lblFraisEssence.Text = "Frais essence";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Frais hôtel";
            // 
            // lblFraisRepas
            // 
            this.lblFraisRepas.AutoSize = true;
            this.lblFraisRepas.Location = new System.Drawing.Point(47, 133);
            this.lblFraisRepas.Name = "lblFraisRepas";
            this.lblFraisRepas.Size = new System.Drawing.Size(88, 20);
            this.lblFraisRepas.TabIndex = 12;
            this.lblFraisRepas.Text = "Frais repas";
            // 
            // lblCollaborateur
            // 
            this.lblCollaborateur.AutoSize = true;
            this.lblCollaborateur.Location = new System.Drawing.Point(47, 50);
            this.lblCollaborateur.Name = "lblCollaborateur";
            this.lblCollaborateur.Size = new System.Drawing.Size(138, 20);
            this.lblCollaborateur.TabIndex = 11;
            this.lblCollaborateur.Text = "Nom collaborateur";
            // 
            // frmSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateFacture);
            this.Controls.Add(this.cmdEnvoyer);
            this.Controls.Add(this.txtFraisEssence);
            this.Controls.Add(this.txtFraisHotel);
            this.Controls.Add(this.txtFraisRepas);
            this.Controls.Add(this.lblFraisEssence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFraisRepas);
            this.Controls.Add(this.lblCollaborateur);
            this.Name = "frmSaisie";
            this.Text = "Saisie";
            this.Load += new System.EventHandler(this.frmSaisie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateFacture;
        private System.Windows.Forms.Button cmdEnvoyer;
        private System.Windows.Forms.TextBox txtFraisEssence;
        private System.Windows.Forms.TextBox txtFraisHotel;
        private System.Windows.Forms.TextBox txtFraisRepas;
        private System.Windows.Forms.Label lblFraisEssence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFraisRepas;
        private System.Windows.Forms.Label lblCollaborateur;
    }
}