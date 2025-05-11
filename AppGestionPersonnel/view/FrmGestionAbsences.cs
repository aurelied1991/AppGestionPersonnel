using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionPersonnel.model;
using AppGestionPersonnel.view;
using AppGestionPersonnel.controller;

namespace AppGestionPersonnel.view
{
    /// <summary>
    /// Fenêtre de gestion des absences
    /// </summary>
    public partial class FrmGestionAbsences : Form
    {
        private int idPersonnel;

        //object d'accès aux opérations possibles sur FrmGestionAbsences
        private FrmGestionAbsencesController controller;

        /// <summary>
        /// Valorisation de la propriété FrmGestionAbsencesController, création contrôleur
        /// </summary>
        public void Init()
        {
            //Création du contrôleur
            controller = new FrmGestionAbsencesController(idPersonnel);
            //Remplissage de la liste des absences
            RemplirListeAbsences();
            //Remplir liste des motifs
            RemplirListeMotifs();
        }

        /// <summary>
        /// Construction des composants graphiques et initialisation
        /// </summary>
        public FrmGestionAbsences(int idPersonnel)
        {
            InitializeComponent();
            this.idPersonnel = idPersonnel;
            Init();
        }

        /// <summary>
        /// Remplissage de la liste des absences selon le personnel sélectionné
        /// </summary>
        public void RemplirListeAbsences()
        {
            List<Absences> lesAbsences = controller.GetLesAbsences(idPersonnel);
            dgvAbsences.DataSource = lesAbsences;
            dgvAbsences.Columns["IdPersonnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Remplissage de la liste des motifs
        /// </summary>
        public void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            cboMotifAbsence.DataSource = lesMotifs;
            cboMotifAbsence.DisplayMember = "Libelle";
            cboMotifAbsence.ValueMember = "IdMotif";
            cboMotifAbsence.SelectedIndex = -1; // Aucune sélection par défaut
        }
    }
}
