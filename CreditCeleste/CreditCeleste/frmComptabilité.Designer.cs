
namespace CreditCeleste
{
    partial class frmComptabilite
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
            this.lstBoxFacture = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxFacture
            // 
            this.lstBoxFacture.FormattingEnabled = true;
            this.lstBoxFacture.ItemHeight = 16;
            this.lstBoxFacture.Location = new System.Drawing.Point(187, 117);
            this.lstBoxFacture.Name = "lstBoxFacture";
            this.lstBoxFacture.Size = new System.Drawing.Size(369, 148);
            this.lstBoxFacture.TabIndex = 0;
            // 
            // frmComptabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxFacture);
            this.Name = "frmComptabilite";
            this.Text = "Comptabilité";
            this.Load += new System.EventHandler(this.frmComptabilite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxFacture;
    }
}