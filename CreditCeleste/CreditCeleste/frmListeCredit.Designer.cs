
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
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRetour = new System.Windows.Forms.Button();
            this.lsbLesCredits = new System.Windows.Forms.ListBox();
            this.cmdBDD = new System.Windows.Forms.Button();
            this.cmdInit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(150, 266);
            this.btnEnregistre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(82, 30);
            this.btnEnregistre.TabIndex = 1;
            this.btnEnregistre.Text = "Enregistrer";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(369, 266);
            this.btnRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(56, 30);
            this.btnRetour.TabIndex = 2;
            this.btnRetour.Text = "Accueil";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // lsbLesCredits
            // 
            this.lsbLesCredits.FormattingEnabled = true;
            this.lsbLesCredits.Location = new System.Drawing.Point(150, 81);
            this.lsbLesCredits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbLesCredits.Name = "lsbLesCredits";
            this.lsbLesCredits.Size = new System.Drawing.Size(276, 121);
            this.lsbLesCredits.TabIndex = 3;
            this.lsbLesCredits.SelectedIndexChanged += new System.EventHandler(this.lsbLesCredits_SelectedIndexChanged);
            // 
            // cmdBDD
            // 
            this.cmdBDD.Location = new System.Drawing.Point(260, 266);
            this.cmdBDD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdBDD.Name = "cmdBDD";
            this.cmdBDD.Size = new System.Drawing.Size(82, 30);
            this.cmdBDD.TabIndex = 4;
            this.cmdBDD.Text = "BDD";
            this.cmdBDD.UseVisualStyleBackColor = true;
            this.cmdBDD.Click += new System.EventHandler(this.cmdBDD_Click);
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(448, 266);
            this.cmdInit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(56, 30);
            this.cmdInit.TabIndex = 5;
            this.cmdInit.Text = "init";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // frmListeCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.cmdBDD);
            this.Controls.Add(this.lsbLesCredits);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnEnregistre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListeCredit";
            this.Text = "listeCredit";
            this.Load += new System.EventHandler(this.listeCredit_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEnregistre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.ListBox lsbLesCredits;
        private System.Windows.Forms.Button cmdBDD;
        private System.Windows.Forms.Button cmdInit;
    }
}