
namespace CreditCeleste
{
    partial class frmDetailsFacture
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
            this.lblNumVisite = new System.Windows.Forms.Label();
            this.lblTypeFrais = new System.Windows.Forms.Label();
            this.lblDateFacture = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.txtBoxMontantRembourser = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumFacture = new System.Windows.Forms.Label();
            this.radioButtonRembourseTrue = new System.Windows.Forms.RadioButton();
            this.radioButtonRembourserFalse = new System.Windows.Forms.RadioButton();
            this.groupBoxRembourser = new System.Windows.Forms.GroupBox();
            this.lblRembourserBool = new System.Windows.Forms.Label();
            this.lblRAC = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.groupBoxRembourser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumVisite
            // 
            this.lblNumVisite.AutoSize = true;
            this.lblNumVisite.Location = new System.Drawing.Point(12, 41);
            this.lblNumVisite.Name = "lblNumVisite";
            this.lblNumVisite.Size = new System.Drawing.Size(52, 13);
            this.lblNumVisite.TabIndex = 0;
            this.lblNumVisite.Text = "numVisite";
            // 
            // lblTypeFrais
            // 
            this.lblTypeFrais.AutoSize = true;
            this.lblTypeFrais.Location = new System.Drawing.Point(58, 132);
            this.lblTypeFrais.Name = "lblTypeFrais";
            this.lblTypeFrais.Size = new System.Drawing.Size(49, 13);
            this.lblTypeFrais.TabIndex = 1;
            this.lblTypeFrais.Text = "typeFrais";
            // 
            // lblDateFacture
            // 
            this.lblDateFacture.AutoSize = true;
            this.lblDateFacture.Location = new System.Drawing.Point(58, 166);
            this.lblDateFacture.Name = "lblDateFacture";
            this.lblDateFacture.Size = new System.Drawing.Size(64, 13);
            this.lblDateFacture.TabIndex = 2;
            this.lblDateFacture.Text = "dateFacture";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(58, 197);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(81, 13);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "montantFacture";
            // 
            // txtBoxMontantRembourser
            // 
            this.txtBoxMontantRembourser.Location = new System.Drawing.Point(44, 282);
            this.txtBoxMontantRembourser.Name = "txtBoxMontantRembourser";
            this.txtBoxMontantRembourser.Size = new System.Drawing.Size(86, 20);
            this.txtBoxMontantRembourser.TabIndex = 5;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(44, 371);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 7;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Montant remboursé";
            // 
            // lblNumFacture
            // 
            this.lblNumFacture.AutoSize = true;
            this.lblNumFacture.Location = new System.Drawing.Point(12, 73);
            this.lblNumFacture.Name = "lblNumFacture";
            this.lblNumFacture.Size = new System.Drawing.Size(63, 13);
            this.lblNumFacture.TabIndex = 9;
            this.lblNumFacture.Text = "numFacture";
            // 
            // radioButtonRembourseTrue
            // 
            this.radioButtonRembourseTrue.AutoSize = true;
            this.radioButtonRembourseTrue.Location = new System.Drawing.Point(6, 34);
            this.radioButtonRembourseTrue.Name = "radioButtonRembourseTrue";
            this.radioButtonRembourseTrue.Size = new System.Drawing.Size(79, 17);
            this.radioButtonRembourseTrue.TabIndex = 10;
            this.radioButtonRembourseTrue.TabStop = true;
            this.radioButtonRembourseTrue.Text = "Remboursé";
            this.radioButtonRembourseTrue.UseVisualStyleBackColor = true;
            // 
            // radioButtonRembourserFalse
            // 
            this.radioButtonRembourserFalse.AutoSize = true;
            this.radioButtonRembourserFalse.Location = new System.Drawing.Point(6, 57);
            this.radioButtonRembourserFalse.Name = "radioButtonRembourserFalse";
            this.radioButtonRembourserFalse.Size = new System.Drawing.Size(97, 17);
            this.radioButtonRembourserFalse.TabIndex = 11;
            this.radioButtonRembourserFalse.TabStop = true;
            this.radioButtonRembourserFalse.Text = "Non remboursé";
            this.radioButtonRembourserFalse.UseVisualStyleBackColor = true;
            // 
            // groupBoxRembourser
            // 
            this.groupBoxRembourser.Controls.Add(this.radioButtonRembourseTrue);
            this.groupBoxRembourser.Controls.Add(this.radioButtonRembourserFalse);
            this.groupBoxRembourser.Location = new System.Drawing.Point(210, 266);
            this.groupBoxRembourser.Name = "groupBoxRembourser";
            this.groupBoxRembourser.Size = new System.Drawing.Size(124, 95);
            this.groupBoxRembourser.TabIndex = 12;
            this.groupBoxRembourser.TabStop = false;
            this.groupBoxRembourser.Text = "Statut";
            // 
            // lblRembourserBool
            // 
            this.lblRembourserBool.AutoSize = true;
            this.lblRembourserBool.Location = new System.Drawing.Point(12, 103);
            this.lblRembourserBool.Name = "lblRembourserBool";
            this.lblRembourserBool.Size = new System.Drawing.Size(61, 13);
            this.lblRembourserBool.TabIndex = 13;
            this.lblRembourserBool.Text = "Remoursé?";
            // 
            // lblRAC
            // 
            this.lblRAC.AutoSize = true;
            this.lblRAC.Location = new System.Drawing.Point(207, 41);
            this.lblRAC.Name = "lblRAC";
            this.lblRAC.Size = new System.Drawing.Size(75, 13);
            this.lblRAC.TabIndex = 14;
            this.lblRAC.Text = "reste à charge";
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(464, 76);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(276, 20);
            this.txtCommentaire.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Commentaire";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(41, 229);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 17;
            this.lblDistance.Text = "Distance";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(44, 245);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 18;
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // frmDetailsFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.lblRAC);
            this.Controls.Add(this.lblRembourserBool);
            this.Controls.Add(this.groupBoxRembourser);
            this.Controls.Add(this.lblNumFacture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtBoxMontantRembourser);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDateFacture);
            this.Controls.Add(this.lblTypeFrais);
            this.Controls.Add(this.lblNumVisite);
            this.Name = "frmDetailsFacture";
            this.Text = "frmDetailsFacture";
            this.Load += new System.EventHandler(this.frmDetailsFacture_Load);
            this.groupBoxRembourser.ResumeLayout(false);
            this.groupBoxRembourser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumVisite;
        private System.Windows.Forms.Label lblTypeFrais;
        private System.Windows.Forms.Label lblDateFacture;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox txtBoxMontantRembourser;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumFacture;
        private System.Windows.Forms.RadioButton radioButtonRembourseTrue;
        private System.Windows.Forms.RadioButton radioButtonRembourserFalse;
        private System.Windows.Forms.GroupBox groupBoxRembourser;
        private System.Windows.Forms.Label lblRembourserBool;
        private System.Windows.Forms.Label lblRAC;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
    }
}