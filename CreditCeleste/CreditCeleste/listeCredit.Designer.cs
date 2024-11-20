
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
            this.lstCredits = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCredits
            // 
            this.lstCredits.FormattingEnabled = true;
            this.lstCredits.ItemHeight = 16;
            this.lstCredits.Location = new System.Drawing.Point(159, 155);
            this.lstCredits.Name = "lstCredits";
            this.lstCredits.Size = new System.Drawing.Size(468, 132);
            this.lstCredits.TabIndex = 0;
            this.lstCredits.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmListeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCredits);
            this.Name = "frmListeCredit";
            this.Text = "listeCredit";
            this.Load += new System.EventHandler(this.listeCredit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCredits;
    }
}