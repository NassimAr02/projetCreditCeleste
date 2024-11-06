
namespace travailCredit
{
    partial class frmCredit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontantFinancé = new System.Windows.Forms.TextBox();
            this.cbxDurée = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTauxAnnuel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMensualite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant Financé";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMontantFinancé
            // 
            this.txtMontantFinancé.Location = new System.Drawing.Point(68, 59);
            this.txtMontantFinancé.Name = "txtMontantFinancé";
            this.txtMontantFinancé.Size = new System.Drawing.Size(121, 22);
            this.txtMontantFinancé.TabIndex = 1;
            this.txtMontantFinancé.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbxDurée
            // 
            this.cbxDurée.FormattingEnabled = true;
            this.cbxDurée.Location = new System.Drawing.Point(68, 129);
            this.cbxDurée.Name = "cbxDurée";
            this.cbxDurée.Size = new System.Drawing.Size(121, 24);
            this.cbxDurée.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Durée en mois";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTauxAnnuel
            // 
            this.txtTauxAnnuel.Location = new System.Drawing.Point(68, 217);
            this.txtTauxAnnuel.Name = "txtTauxAnnuel";
            this.txtTauxAnnuel.Size = new System.Drawing.Size(121, 22);
            this.txtTauxAnnuel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Taux Annuel";
            // 
            // txtMensualite
            // 
            this.txtMensualite.Location = new System.Drawing.Point(68, 291);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.Size = new System.Drawing.Size(121, 22);
            this.txtMensualite.TabIndex = 7;
            this.txtMensualite.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mensualité";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(284, 329);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(75, 29);
            this.btnCalcul.TabIndex = 8;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // frmCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.txtMensualite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTauxAnnuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDurée);
            this.Controls.Add(this.txtMontantFinancé);
            this.Controls.Add(this.label1);
            this.Name = "frmCredit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontantFinancé;
        private System.Windows.Forms.ComboBox cbxDurée;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTauxAnnuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMensualite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcul;
    }
}

