
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
            this.lstBoxFactures = new System.Windows.Forms.ListBox();
            this.btnBDDfill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxFactures
            // 
            this.lstBoxFactures.FormattingEnabled = true;
            this.lstBoxFactures.ItemHeight = 16;
            this.lstBoxFactures.Location = new System.Drawing.Point(147, 123);
            this.lstBoxFactures.Name = "lstBoxFactures";
            this.lstBoxFactures.Size = new System.Drawing.Size(400, 212);
            this.lstBoxFactures.TabIndex = 0;
            this.lstBoxFactures.SelectedIndexChanged += new System.EventHandler(this.lstBoxFactures_SelectedIndexChanged);
            // 
            // btnBDDfill
            // 
            this.btnBDDfill.Location = new System.Drawing.Point(628, 143);
            this.btnBDDfill.Name = "btnBDDfill";
            this.btnBDDfill.Size = new System.Drawing.Size(75, 23);
            this.btnBDDfill.TabIndex = 1;
            this.btnBDDfill.Text = "Remplir lstbox";
            this.btnBDDfill.UseVisualStyleBackColor = true;
            this.btnBDDfill.Click += new System.EventHandler(this.btnBDDfill_Click);
            // 
            // frmComptabilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBDDfill);
            this.Controls.Add(this.lstBoxFactures);
            this.Name = "frmComptabilite";
            this.Text = "Comptabilité";
            this.Load += new System.EventHandler(this.frmComptabilite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxFactures;
        private System.Windows.Forms.Button btnBDDfill;
    }
}