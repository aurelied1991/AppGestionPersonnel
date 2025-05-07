namespace AppGestionPersonnel.view
{
    partial class FrmGestionPersonnel
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
            this.gboPersonnel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAfficherAbsences = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnModifierPersonnel = new System.Windows.Forms.Button();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.lblSaisieInfos = new System.Windows.Forms.Label();
            this.gboSaisieInfos = new System.Windows.Forms.GroupBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnValiderAjout = new System.Windows.Forms.Button();
            this.btnValiderModif = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.gboPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.gboSaisieInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboPersonnel
            // 
            this.gboPersonnel.Controls.Add(this.label1);
            this.gboPersonnel.Controls.Add(this.btnAfficherAbsences);
            this.gboPersonnel.Controls.Add(this.btnSupprimerPersonnel);
            this.gboPersonnel.Controls.Add(this.btnModifierPersonnel);
            this.gboPersonnel.Controls.Add(this.btnAjouterPersonnel);
            this.gboPersonnel.Controls.Add(this.dgvPersonnel);
            this.gboPersonnel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPersonnel.Location = new System.Drawing.Point(12, 12);
            this.gboPersonnel.Name = "gboPersonnel";
            this.gboPersonnel.Size = new System.Drawing.Size(765, 604);
            this.gboPersonnel.TabIndex = 0;
            this.gboPersonnel.TabStop = false;
            this.gboPersonnel.Text = "Liste du personnel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aucun personnel sélectionné";
            this.label1.Visible = false;
            // 
            // btnAfficherAbsences
            // 
            this.btnAfficherAbsences.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherAbsences.Location = new System.Drawing.Point(7, 535);
            this.btnAfficherAbsences.Name = "btnAfficherAbsences";
            this.btnAfficherAbsences.Size = new System.Drawing.Size(205, 40);
            this.btnAfficherAbsences.TabIndex = 4;
            this.btnAfficherAbsences.Text = "Afficher les absences";
            this.btnAfficherAbsences.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(523, 472);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(232, 40);
            this.btnSupprimerPersonnel.TabIndex = 3;
            this.btnSupprimerPersonnel.Text = "Supprimer un personnel";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifierPersonnel
            // 
            this.btnModifierPersonnel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierPersonnel.Location = new System.Drawing.Point(261, 472);
            this.btnModifierPersonnel.Name = "btnModifierPersonnel";
            this.btnModifierPersonnel.Size = new System.Drawing.Size(215, 40);
            this.btnModifierPersonnel.TabIndex = 2;
            this.btnModifierPersonnel.Text = "Modifier un personnel";
            this.btnModifierPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(7, 472);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(205, 40);
            this.btnAjouterPersonnel.TabIndex = 1;
            this.btnAjouterPersonnel.Text = "Ajouter un personnel";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(0, 42);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.Size = new System.Drawing.Size(755, 416);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // lblSaisieInfos
            // 
            this.lblSaisieInfos.AutoSize = true;
            this.lblSaisieInfos.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaisieInfos.Location = new System.Drawing.Point(821, 12);
            this.lblSaisieInfos.Name = "lblSaisieInfos";
            this.lblSaisieInfos.Size = new System.Drawing.Size(360, 28);
            this.lblSaisieInfos.TabIndex = 1;
            this.lblSaisieInfos.Text = "Saisie des informations du personnel";
            // 
            // gboSaisieInfos
            // 
            this.gboSaisieInfos.Controls.Add(this.cboService);
            this.gboSaisieInfos.Controls.Add(this.txtMail);
            this.gboSaisieInfos.Controls.Add(this.txtTel);
            this.gboSaisieInfos.Controls.Add(this.txtPrenom);
            this.gboSaisieInfos.Controls.Add(this.txtNom);
            this.gboSaisieInfos.Controls.Add(this.button1);
            this.gboSaisieInfos.Controls.Add(this.label2);
            this.gboSaisieInfos.Controls.Add(this.lblService);
            this.gboSaisieInfos.Controls.Add(this.lblMail);
            this.gboSaisieInfos.Controls.Add(this.lblTel);
            this.gboSaisieInfos.Controls.Add(this.lblPrenom);
            this.gboSaisieInfos.Controls.Add(this.lblNom);
            this.gboSaisieInfos.Location = new System.Drawing.Point(783, 54);
            this.gboSaisieInfos.Name = "gboSaisieInfos";
            this.gboSaisieInfos.Size = new System.Drawing.Size(419, 370);
            this.gboSaisieInfos.TabIndex = 2;
            this.gboSaisieInfos.TabStop = false;
            // 
            // cboService
            // 
            this.cboService.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(214, 285);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(189, 32);
            this.cboService.TabIndex = 11;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(111, 219);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(292, 32);
            this.txtMail.TabIndex = 10;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(111, 150);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(292, 32);
            this.txtTel.TabIndex = 9;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(111, 82);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(292, 32);
            this.txtPrenom.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(111, 15);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 32);
            this.txtNom.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Les champs ne sont pas tous remplis";
            this.label2.Visible = false;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.Location = new System.Drawing.Point(20, 288);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(188, 24);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service d\'affectation :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(20, 222);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(62, 24);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail : ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(20, 153);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(43, 24);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Tel :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(20, 85);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(85, 24);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(17, 18);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(60, 24);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // btnValiderAjout
            // 
            this.btnValiderAjout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderAjout.Location = new System.Drawing.Point(804, 430);
            this.btnValiderAjout.Name = "btnValiderAjout";
            this.btnValiderAjout.Size = new System.Drawing.Size(163, 40);
            this.btnValiderAjout.TabIndex = 3;
            this.btnValiderAjout.Text = "Valider l\'ajout";
            this.btnValiderAjout.UseVisualStyleBackColor = true;
            // 
            // btnValiderModif
            // 
            this.btnValiderModif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderModif.Location = new System.Drawing.Point(804, 484);
            this.btnValiderModif.Name = "btnValiderModif";
            this.btnValiderModif.Size = new System.Drawing.Size(222, 40);
            this.btnValiderModif.TabIndex = 4;
            this.btnValiderModif.Text = "Valider les modifications";
            this.btnValiderModif.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(804, 547);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(170, 40);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(1059, 547);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(143, 40);
            this.btnDeconnexion.TabIndex = 6;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // FrmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 620);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValiderModif);
            this.Controls.Add(this.btnValiderAjout);
            this.Controls.Add(this.gboSaisieInfos);
            this.Controls.Add(this.lblSaisieInfos);
            this.Controls.Add(this.gboPersonnel);
            this.Name = "FrmGestionPersonnel";
            this.Text = "Gestion du personnel de la médiathèque";
            this.gboPersonnel.ResumeLayout(false);
            this.gboPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.gboSaisieInfos.ResumeLayout(false);
            this.gboSaisieInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnModifierPersonnel;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAfficherAbsences;
        private System.Windows.Forms.Label lblSaisieInfos;
        private System.Windows.Forms.GroupBox gboSaisieInfos;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValiderAjout;
        private System.Windows.Forms.Button btnValiderModif;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboService;
    }
}