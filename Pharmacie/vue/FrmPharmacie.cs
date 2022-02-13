using Pharmacie.controleur;
using Pharmacie.modele;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pharmacie.vue
{
    /// <summary>
    /// Classe FrmPharmacie : affichage des médicaments, ajoute et suppression
    /// </summary>
    public partial class FrmPharmacie : Form
    {
        private readonly BindingSource bdgMedicaments = new BindingSource();
        private readonly BindingSource bdgRecommandations = new BindingSource();
        private Controle controle;

        /// <summary>
        /// Consutructeur : initialisation des objets graphiques et appel de la méthode Init
        /// </summary>
        public FrmPharmacie(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation des objets de connexion à la BDD
        /// appel des méthodes de chargement des listes graphiques
        /// </summary>
        private void Init()
        {
            RemplirGridMedicaments();
            RemplirCboRecommandations();
        }

        /// <summary>
        /// Chargement du grid des médicaments
        /// </summary>
        private void RemplirGridMedicaments()
        {
            dgvMedicaments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing; // pour améliorer le temps de chargement
            List<Medicament> lesMedicaments = controle.GetMedicaments();
            lesMedicaments.Sort();
            bdgMedicaments.DataSource = lesMedicaments;
            dgvMedicaments.DataSource = bdgMedicaments;
            dgvMedicaments.Columns["Id"].Visible = false;
            dgvMedicaments.Columns["libelle"].HeaderText = "libellé ATC3";
            dgvMedicaments.Columns["forme"].HeaderText = "forme galénique"; 
            dgvMedicaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Chargement du combo des recommandations
        /// </summary>
        private void RemplirCboRecommandations()
        {
            bdgRecommandations.DataSource = controle.GetRecommandations();
            cboRecommandations.DataSource = bdgRecommandations;
            if(cboRecommandations.Items.Count > 0)
            {
                cboRecommandations.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Evénement clic sur le bouton supprimer : demande de suppression du médicament sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            if(dgvMedicaments.SelectedRows.Count > 0)
            {
                Medicament medicament = (Medicament)bdgMedicaments.List[bdgMedicaments.Position];
                if(MessageBox.Show("Voulez vous vraiment supprimer "+medicament.nom+" ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SupprMedicament(medicament);
                    RemplirGridMedicaments();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande de suppression d'un médicament
        /// </summary>
        /// <param name="medicament"></param>
        private void SupprMedicament(Medicament medicament)
        {
            controle.SupprMedicament(medicament);
        }

        /// <summary>
        /// Evénement clic sur le bouton ajouter : demande d'ajout d'un médicament
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAjout_Click(object sender, EventArgs e)
        {
            if(!txtForme.Text.Equals("") && !txtLibelleATC3.Text.Equals("") && !txtNom.Text.Equals(""))
            {
                AjoutMedicament();
                RemplirGridMedicaments();
                ReinitialiseZoneSaisie();
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// demande d'ajout d'un médicament dans la BDD à partir des informations saisies
        /// </summary>
        private void AjoutMedicament()
        {
            Recommandation recommandation = (Recommandation)bdgRecommandations.List[bdgRecommandations.Position];
            controle.AjoutMedicament(txtNom.Text, txtLibelleATC3.Text, txtForme.Text, recommandation.code);
        }

        /// <summary>
        /// Réinitialise la zone de saisie du médicament en vidant les champs
        /// </summary>
        private void ReinitialiseZoneSaisie()
        {
            txtForme.Text = "";
            txtLibelleATC3.Text = "";
            txtNom.Text = "";
            if (cboRecommandations.Items.Count > 0)
            {
                cboRecommandations.SelectedIndex = 0;
            }
        }

    }
}
