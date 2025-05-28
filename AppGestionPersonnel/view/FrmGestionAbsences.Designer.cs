namespace AppGestionPersonnel.view
{
    partial class FrmGestionAbsences
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
            this.gboListeAbsences = new System.Windows.Forms.GroupBox();
            this.lblAucuneSelection = new System.Windows.Forms.Label();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.lblSaisieAbsence = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.gboSaisieInfosAbsence = new System.Windows.Forms.GroupBox();
            this.dtpFinAbsence = new System.Windows.Forms.DateTimePicker();
            this.dtpDebutAbsence = new System.Windows.Forms.DateTimePicker();
            this.cboMotifAbsence = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblProblemeDate = new System.Windows.Forms.Label();
            this.lblCreneauNonLibre = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.btnEnregistrerModifications = new System.Windows.Forms.Button();
            this.btnAnnulerAction = new System.Windows.Forms.Button();
            this.btnRetourPersonnel = new System.Windows.Forms.Button();
            this.gboListeAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.gboSaisieInfosAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboListeAbsences
            // 
            this.gboListeAbsences.Controls.Add(this.lblAucuneSelection);
            this.gboListeAbsences.Controls.Add(this.btnSupprimerAbsence);
            this.gboListeAbsences.Controls.Add(this.btnModifAbsence);
            this.gboListeAbsences.Controls.Add(this.btnAjoutAbsence);
            this.gboListeAbsences.Controls.Add(this.dgvAbsences);
            this.gboListeAbsences.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboListeAbsences.Location = new System.Drawing.Point(3, 13);
            this.gboListeAbsences.Name = "gboListeAbsences";
            this.gboListeAbsences.Size = new System.Drawing.Size(699, 570);
            this.gboListeAbsences.TabIndex = 0;
            this.gboListeAbsences.TabStop = false;
            this.gboListeAbsences.Text = "Liste des absences";
            // 
            // lblAucuneSelection
            // 
            this.lblAucuneSelection.AutoSize = true;
            this.lblAucuneSelection.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAucuneSelection.ForeColor = System.Drawing.Color.Red;
            this.lblAucuneSelection.Location = new System.Drawing.Point(9, 545);
            this.lblAucuneSelection.Name = "lblAucuneSelection";
            this.lblAucuneSelection.Size = new System.Drawing.Size(445, 22);
            this.lblAucuneSelection.TabIndex = 4;
            this.lblAucuneSelection.Text = "Attention, une absence doit être sélectionnée dans la liste";
            this.lblAucuneSelection.Visible = false;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(465, 498);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(228, 34);
            this.btnSupprimerAbsence.TabIndex = 3;
            this.btnSupprimerAbsence.Text = "Supprimer une absence";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifAbsence.Location = new System.Drawing.Point(229, 498);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(211, 34);
            this.btnModifAbsence.TabIndex = 2;
            this.btnModifAbsence.Text = "Modifier une absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            this.btnModifAbsence.Click += new System.EventHandler(this.btnModifAbsence_Click);
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutAbsence.Location = new System.Drawing.Point(0, 498);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(206, 34);
            this.btnAjoutAbsence.TabIndex = 1;
            this.btnAjoutAbsence.Text = "Ajouter une absence";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            this.btnAjoutAbsence.Click += new System.EventHandler(this.btnAjoutAbsence_Click);
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(0, 36);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersWidth = 51;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(693, 421);
            this.dgvAbsences.TabIndex = 0;
            // 
            // lblSaisieAbsence
            // 
            this.lblSaisieAbsence.AutoSize = true;
            this.lblSaisieAbsence.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaisieAbsence.Location = new System.Drawing.Point(782, 13);
            this.lblSaisieAbsence.Name = "lblSaisieAbsence";
            this.lblSaisieAbsence.Size = new System.Drawing.Size(359, 28);
            this.lblSaisieAbsence.TabIndex = 1;
            this.lblSaisieAbsence.Text = "Saisie des informations sur l\'absence";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(6, 18);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(248, 24);
            this.lblDateDebut.TabIndex = 2;
            this.lblDateDebut.Text = "Date de début de l\'absence :";
            // 
            // gboSaisieInfosAbsence
            // 
            this.gboSaisieInfosAbsence.Controls.Add(this.dtpFinAbsence);
            this.gboSaisieInfosAbsence.Controls.Add(this.dtpDebutAbsence);
            this.gboSaisieInfosAbsence.Controls.Add(this.cboMotifAbsence);
            this.gboSaisieInfosAbsence.Controls.Add(this.lblMotif);
            this.gboSaisieInfosAbsence.Controls.Add(this.lblProblemeDate);
            this.gboSaisieInfosAbsence.Controls.Add(this.lblCreneauNonLibre);
            this.gboSaisieInfosAbsence.Controls.Add(this.lblDateFin);
            this.gboSaisieInfosAbsence.Controls.Add(this.lblDateDebut);
            this.gboSaisieInfosAbsence.Enabled = false;
            this.gboSaisieInfosAbsence.Location = new System.Drawing.Point(702, 49);
            this.gboSaisieInfosAbsence.Name = "gboSaisieInfosAbsence";
            this.gboSaisieInfosAbsence.Size = new System.Drawing.Size(514, 249);
            this.gboSaisieInfosAbsence.TabIndex = 3;
            this.gboSaisieInfosAbsence.TabStop = false;
            // 
            // dtpFinAbsence
            // 
            this.dtpFinAbsence.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinAbsence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinAbsence.Location = new System.Drawing.Point(271, 85);
            this.dtpFinAbsence.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpFinAbsence.Name = "dtpFinAbsence";
            this.dtpFinAbsence.Size = new System.Drawing.Size(146, 29);
            this.dtpFinAbsence.TabIndex = 9;
            // 
            // dtpDebutAbsence
            // 
            this.dtpDebutAbsence.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDebutAbsence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDebutAbsence.Location = new System.Drawing.Point(271, 18);
            this.dtpDebutAbsence.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpDebutAbsence.Name = "dtpDebutAbsence";
            this.dtpDebutAbsence.Size = new System.Drawing.Size(146, 29);
            this.dtpDebutAbsence.TabIndex = 8;
            this.dtpDebutAbsence.Value = new System.DateTime(2025, 5, 11, 0, 0, 0, 0);
            // 
            // cboMotifAbsence
            // 
            this.cboMotifAbsence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotifAbsence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotifAbsence.FormattingEnabled = true;
            this.cboMotifAbsence.Location = new System.Drawing.Point(209, 207);
            this.cboMotifAbsence.Name = "cboMotifAbsence";
            this.cboMotifAbsence.Size = new System.Drawing.Size(180, 32);
            this.cboMotifAbsence.TabIndex = 7;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(6, 210);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(173, 24);
            this.lblMotif.TabIndex = 6;
            this.lblMotif.Text = "Motif de l\'absence :";
            // 
            // lblProblemeDate
            // 
            this.lblProblemeDate.AutoSize = true;
            this.lblProblemeDate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemeDate.ForeColor = System.Drawing.Color.Red;
            this.lblProblemeDate.Location = new System.Drawing.Point(6, 149);
            this.lblProblemeDate.Name = "lblProblemeDate";
            this.lblProblemeDate.Size = new System.Drawing.Size(460, 22);
            this.lblProblemeDate.TabIndex = 5;
            this.lblProblemeDate.Text = "La date de fin ne peut pas être antérieure à la date de début";
            this.lblProblemeDate.Visible = false;
            // 
            // lblCreneauNonLibre
            // 
            this.lblCreneauNonLibre.AutoSize = true;
            this.lblCreneauNonLibre.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreneauNonLibre.ForeColor = System.Drawing.Color.Red;
            this.lblCreneauNonLibre.Location = new System.Drawing.Point(6, 118);
            this.lblCreneauNonLibre.Name = "lblCreneauNonLibre";
            this.lblCreneauNonLibre.Size = new System.Drawing.Size(454, 22);
            this.lblCreneauNonLibre.TabIndex = 4;
            this.lblCreneauNonLibre.Text = "Erreur, une absence est déjà enregistrée pour cette période";
            this.lblCreneauNonLibre.Visible = false;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.Location = new System.Drawing.Point(6, 85);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(220, 24);
            this.lblDateFin.TabIndex = 3;
            this.lblDateFin.Text = "Date de fin de l\'absence :";
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Enabled = false;
            this.btnEnregistrerAbsence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(702, 318);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(197, 33);
            this.btnEnregistrerAbsence.TabIndex = 4;
            this.btnEnregistrerAbsence.Text = "Enregistrer l\'absence";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            this.btnEnregistrerAbsence.Click += new System.EventHandler(this.btnEnregistrerAbsence_Click);
            // 
            // btnEnregistrerModifications
            // 
            this.btnEnregistrerModifications.Enabled = false;
            this.btnEnregistrerModifications.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerModifications.Location = new System.Drawing.Point(702, 377);
            this.btnEnregistrerModifications.Name = "btnEnregistrerModifications";
            this.btnEnregistrerModifications.Size = new System.Drawing.Size(280, 33);
            this.btnEnregistrerModifications.TabIndex = 5;
            this.btnEnregistrerModifications.Text = "Enregistrer les modifications";
            this.btnEnregistrerModifications.UseVisualStyleBackColor = true;
            this.btnEnregistrerModifications.Click += new System.EventHandler(this.btnEnregistrerModifications_Click);
            // 
            // btnAnnulerAction
            // 
            this.btnAnnulerAction.Enabled = false;
            this.btnAnnulerAction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerAction.Location = new System.Drawing.Point(702, 436);
            this.btnAnnulerAction.Name = "btnAnnulerAction";
            this.btnAnnulerAction.Size = new System.Drawing.Size(103, 34);
            this.btnAnnulerAction.TabIndex = 6;
            this.btnAnnulerAction.Text = "Annuler";
            this.btnAnnulerAction.UseVisualStyleBackColor = true;
            this.btnAnnulerAction.Click += new System.EventHandler(this.btnAnnulerAction_Click);
            // 
            // btnRetourPersonnel
            // 
            this.btnRetourPersonnel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourPersonnel.Location = new System.Drawing.Point(886, 511);
            this.btnRetourPersonnel.Name = "btnRetourPersonnel";
            this.btnRetourPersonnel.Size = new System.Drawing.Size(330, 34);
            this.btnRetourPersonnel.TabIndex = 7;
            this.btnRetourPersonnel.Text = "Retour à la gestion du personnel";
            this.btnRetourPersonnel.UseVisualStyleBackColor = true;
            this.btnRetourPersonnel.Click += new System.EventHandler(this.btnRetourPersonnel_Click);
            // 
            // FrmGestionAbsences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 620);
            this.Controls.Add(this.btnRetourPersonnel);
            this.Controls.Add(this.btnAnnulerAction);
            this.Controls.Add(this.btnEnregistrerModifications);
            this.Controls.Add(this.btnEnregistrerAbsence);
            this.Controls.Add(this.gboSaisieInfosAbsence);
            this.Controls.Add(this.lblSaisieAbsence);
            this.Controls.Add(this.gboListeAbsences);
            this.Name = "FrmGestionAbsences";
            this.Text = "Gestion des absences du personnel";
            this.gboListeAbsences.ResumeLayout(false);
            this.gboListeAbsences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.gboSaisieInfosAbsence.ResumeLayout(false);
            this.gboSaisieInfosAbsence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboListeAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Label lblSaisieAbsence;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.GroupBox gboSaisieInfosAbsence;
        private System.Windows.Forms.Label lblCreneauNonLibre;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.ComboBox cboMotifAbsence;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblProblemeDate;
        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.Button btnEnregistrerModifications;
        private System.Windows.Forms.Button btnAnnulerAction;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button btnRetourPersonnel;
        private System.Windows.Forms.DateTimePicker dtpFinAbsence;
        private System.Windows.Forms.DateTimePicker dtpDebutAbsence;
        private System.Windows.Forms.Label lblAucuneSelection;
    }
}