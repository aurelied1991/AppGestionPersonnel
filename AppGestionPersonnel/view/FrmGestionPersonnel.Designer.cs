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
            this.lblAucuneSelection = new System.Windows.Forms.Label();
            this.BtnAfficherAbsences = new System.Windows.Forms.Button();
            this.BtnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.BtnModifierPersonnel = new System.Windows.Forms.Button();
            this.BtnAjouterPersonnel = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.lblSaisieInfos = new System.Windows.Forms.Label();
            this.gboSaisieInfos = new System.Windows.Forms.GroupBox();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblProblemeChamps = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.BtnValiderAjout = new System.Windows.Forms.Button();
            this.BtnValiderModif = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnDeconnexion = new System.Windows.Forms.Button();
            this.gboPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.gboSaisieInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboPersonnel
            // 
            this.gboPersonnel.Controls.Add(this.lblAucuneSelection);
            this.gboPersonnel.Controls.Add(this.BtnAfficherAbsences);
            this.gboPersonnel.Controls.Add(this.BtnSupprimerPersonnel);
            this.gboPersonnel.Controls.Add(this.BtnModifierPersonnel);
            this.gboPersonnel.Controls.Add(this.BtnAjouterPersonnel);
            this.gboPersonnel.Controls.Add(this.dgvPersonnel);
            this.gboPersonnel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboPersonnel.Location = new System.Drawing.Point(12, 12);
            this.gboPersonnel.Name = "gboPersonnel";
            this.gboPersonnel.Size = new System.Drawing.Size(765, 604);
            this.gboPersonnel.TabIndex = 0;
            this.gboPersonnel.TabStop = false;
            this.gboPersonnel.Text = "Liste du personnel";
            // 
            // lblAucuneSelection
            // 
            this.lblAucuneSelection.AutoSize = true;
            this.lblAucuneSelection.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAucuneSelection.ForeColor = System.Drawing.Color.Red;
            this.lblAucuneSelection.Location = new System.Drawing.Point(6, 578);
            this.lblAucuneSelection.Name = "lblAucuneSelection";
            this.lblAucuneSelection.Size = new System.Drawing.Size(215, 21);
            this.lblAucuneSelection.TabIndex = 5;
            this.lblAucuneSelection.Text = "Aucun personnel sélectionné";
            this.lblAucuneSelection.Visible = false;
            // 
            // BtnAfficherAbsences
            // 
            this.BtnAfficherAbsences.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAfficherAbsences.Location = new System.Drawing.Point(0, 535);
            this.BtnAfficherAbsences.Name = "BtnAfficherAbsences";
            this.BtnAfficherAbsences.Size = new System.Drawing.Size(213, 40);
            this.BtnAfficherAbsences.TabIndex = 4;
            this.BtnAfficherAbsences.Text = "Afficher les absences";
            this.BtnAfficherAbsences.UseVisualStyleBackColor = true;
            this.BtnAfficherAbsences.Click += new System.EventHandler(this.BtnAfficherAbsences_Click);
            // 
            // BtnSupprimerPersonnel
            // 
            this.BtnSupprimerPersonnel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimerPersonnel.Location = new System.Drawing.Point(523, 472);
            this.BtnSupprimerPersonnel.Name = "BtnSupprimerPersonnel";
            this.BtnSupprimerPersonnel.Size = new System.Drawing.Size(232, 40);
            this.BtnSupprimerPersonnel.TabIndex = 3;
            this.BtnSupprimerPersonnel.Text = "Supprimer un personnel";
            this.BtnSupprimerPersonnel.UseVisualStyleBackColor = true;
            this.BtnSupprimerPersonnel.Click += new System.EventHandler(this.BtnSupprimerPersonnel_Click);
            // 
            // BtnModifierPersonnel
            // 
            this.BtnModifierPersonnel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifierPersonnel.Location = new System.Drawing.Point(258, 472);
            this.BtnModifierPersonnel.Name = "BtnModifierPersonnel";
            this.BtnModifierPersonnel.Size = new System.Drawing.Size(218, 40);
            this.BtnModifierPersonnel.TabIndex = 2;
            this.BtnModifierPersonnel.Text = "Modifier un personnel";
            this.BtnModifierPersonnel.UseVisualStyleBackColor = true;
            this.BtnModifierPersonnel.Click += new System.EventHandler(this.BtnModifierPersonnel_Click);
            // 
            // BtnAjouterPersonnel
            // 
            this.BtnAjouterPersonnel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouterPersonnel.Location = new System.Drawing.Point(0, 472);
            this.BtnAjouterPersonnel.Name = "BtnAjouterPersonnel";
            this.BtnAjouterPersonnel.Size = new System.Drawing.Size(213, 40);
            this.BtnAjouterPersonnel.TabIndex = 1;
            this.BtnAjouterPersonnel.Text = "Ajouter un personnel";
            this.BtnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.BtnAjouterPersonnel.Click += new System.EventHandler(this.BtnAjouterPersonnel_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(0, 42);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.gboSaisieInfos.Controls.Add(this.lblProblemeChamps);
            this.gboSaisieInfos.Controls.Add(this.lblService);
            this.gboSaisieInfos.Controls.Add(this.lblMail);
            this.gboSaisieInfos.Controls.Add(this.lblTel);
            this.gboSaisieInfos.Controls.Add(this.lblPrenom);
            this.gboSaisieInfos.Controls.Add(this.lblNom);
            this.gboSaisieInfos.Enabled = false;
            this.gboSaisieInfos.Location = new System.Drawing.Point(783, 54);
            this.gboSaisieInfos.Name = "gboSaisieInfos";
            this.gboSaisieInfos.Size = new System.Drawing.Size(419, 370);
            this.gboSaisieInfos.TabIndex = 2;
            this.gboSaisieInfos.TabStop = false;
            // 
            // cboService
            // 
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // lblProblemeChamps
            // 
            this.lblProblemeChamps.AutoSize = true;
            this.lblProblemeChamps.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemeChamps.ForeColor = System.Drawing.Color.Red;
            this.lblProblemeChamps.Location = new System.Drawing.Point(20, 334);
            this.lblProblemeChamps.Name = "lblProblemeChamps";
            this.lblProblemeChamps.Size = new System.Drawing.Size(283, 22);
            this.lblProblemeChamps.TabIndex = 5;
            this.lblProblemeChamps.Text = "Les champs ne sont pas tous remplis";
            this.lblProblemeChamps.Visible = false;
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
            // BtnValiderAjout
            // 
            this.BtnValiderAjout.Enabled = false;
            this.BtnValiderAjout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValiderAjout.Location = new System.Drawing.Point(804, 430);
            this.BtnValiderAjout.Name = "BtnValiderAjout";
            this.BtnValiderAjout.Size = new System.Drawing.Size(163, 40);
            this.BtnValiderAjout.TabIndex = 3;
            this.BtnValiderAjout.Text = "Valider l\'ajout";
            this.BtnValiderAjout.UseVisualStyleBackColor = true;
            this.BtnValiderAjout.Click += new System.EventHandler(this.BtnValiderAjout_Click);
            // 
            // BtnValiderModif
            // 
            this.BtnValiderModif.Enabled = false;
            this.BtnValiderModif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValiderModif.Location = new System.Drawing.Point(804, 484);
            this.BtnValiderModif.Name = "BtnValiderModif";
            this.BtnValiderModif.Size = new System.Drawing.Size(235, 40);
            this.BtnValiderModif.TabIndex = 4;
            this.BtnValiderModif.Text = "Valider les modifications";
            this.BtnValiderModif.UseVisualStyleBackColor = true;
            this.BtnValiderModif.Click += new System.EventHandler(this.BtnValiderModif_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Enabled = false;
            this.BtnAnnuler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Location = new System.Drawing.Point(804, 547);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(170, 40);
            this.BtnAnnuler.TabIndex = 5;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnDeconnexion
            // 
            this.BtnDeconnexion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeconnexion.Location = new System.Drawing.Point(1059, 547);
            this.BtnDeconnexion.Name = "BtnDeconnexion";
            this.BtnDeconnexion.Size = new System.Drawing.Size(143, 40);
            this.BtnDeconnexion.TabIndex = 6;
            this.BtnDeconnexion.Text = "Déconnexion";
            this.BtnDeconnexion.UseVisualStyleBackColor = true;
            this.BtnDeconnexion.Click += new System.EventHandler(this.BtnDeconnexion_Click);
            // 
            // FrmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 620);
            this.Controls.Add(this.BtnDeconnexion);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnValiderModif);
            this.Controls.Add(this.BtnValiderAjout);
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
        private System.Windows.Forms.Button BtnSupprimerPersonnel;
        private System.Windows.Forms.Button BtnModifierPersonnel;
        private System.Windows.Forms.Button BtnAjouterPersonnel;
        private System.Windows.Forms.Label lblAucuneSelection;
        private System.Windows.Forms.Button BtnAfficherAbsences;
        private System.Windows.Forms.Label lblSaisieInfos;
        private System.Windows.Forms.GroupBox gboSaisieInfos;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblProblemeChamps;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnValiderAjout;
        private System.Windows.Forms.Button BtnValiderModif;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnDeconnexion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cboService;
    }
}