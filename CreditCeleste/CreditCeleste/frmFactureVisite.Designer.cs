
namespace CreditCeleste
{
    partial class frmFactureVisite
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDateDep = new System.Windows.Forms.Label();
            this.lblDateRet = new System.Windows.Forms.Label();
            this.lblVoiturePerso = new System.Windows.Forms.Label();
            this.lblPuissance = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblConcession = new System.Windows.Forms.Label();
            this.lstFactures = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(31, 134);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(52, 13);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "numVisite";
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // lblDateDep
            // 
            this.lblDateDep.AutoSize = true;
            this.lblDateDep.Location = new System.Drawing.Point(31, 156);
            this.lblDateDep.Name = "lblDateDep";
            this.lblDateDep.Size = new System.Drawing.Size(62, 13);
            this.lblDateDep.TabIndex = 1;
            this.lblDateDep.Text = "DateDepart";
            // 
            // lblDateRet
            // 
            this.lblDateRet.AutoSize = true;
            this.lblDateRet.Location = new System.Drawing.Point(31, 183);
            this.lblDateRet.Name = "lblDateRet";
            this.lblDateRet.Size = new System.Drawing.Size(62, 13);
            this.lblDateRet.TabIndex = 2;
            this.lblDateRet.Text = "DateRetour";
            // 
            // lblVoiturePerso
            // 
            this.lblVoiturePerso.AutoSize = true;
            this.lblVoiturePerso.Location = new System.Drawing.Point(31, 207);
            this.lblVoiturePerso.Name = "lblVoiturePerso";
            this.lblVoiturePerso.Size = new System.Drawing.Size(69, 13);
            this.lblVoiturePerso.TabIndex = 3;
            this.lblVoiturePerso.Text = "Voiture perso";
            this.lblVoiturePerso.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPuissance
            // 
            this.lblPuissance.AutoSize = true;
            this.lblPuissance.Location = new System.Drawing.Point(31, 231);
            this.lblPuissance.Name = "lblPuissance";
            this.lblPuissance.Size = new System.Drawing.Size(56, 13);
            this.lblPuissance.TabIndex = 4;
            this.lblPuissance.Text = "Puissance";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(31, 255);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Text = "Distance";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(217, 33);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(53, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Utilisateur";
            // 
            // lblConcession
            // 
            this.lblConcession.AutoSize = true;
            this.lblConcession.Location = new System.Drawing.Point(217, 69);
            this.lblConcession.Name = "lblConcession";
            this.lblConcession.Size = new System.Drawing.Size(62, 13);
            this.lblConcession.TabIndex = 7;
            this.lblConcession.Text = "Concession";
            // 
            // lstFactures
            // 
            this.lstFactures.FormattingEnabled = true;
            this.lstFactures.Location = new System.Drawing.Point(373, 112);
            this.lstFactures.Name = "lstFactures";
            this.lstFactures.Size = new System.Drawing.Size(373, 238);
            this.lstFactures.TabIndex = 8;
            this.lstFactures.SelectedIndexChanged += new System.EventHandler(this.lstFactures_SelectedIndexChanged);
            // 
            // frmFactureVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstFactures);
            this.Controls.Add(this.lblConcession);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblPuissance);
            this.Controls.Add(this.lblVoiturePerso);
            this.Controls.Add(this.lblDateRet);
            this.Controls.Add(this.lblDateDep);
            this.Controls.Add(this.lblNum);
            this.Name = "frmFactureVisite";
            this.Text = "frmFactureVisite";
            this.Load += new System.EventHandler(this.frmFactureVisite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDateDep;
        private System.Windows.Forms.Label lblDateRet;
        private System.Windows.Forms.Label lblVoiturePerso;
        private System.Windows.Forms.Label lblPuissance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblConcession;
        private System.Windows.Forms.ListBox lstFactures;
    }
}