using Pharmacie.modele;
using Pharmacie.vue;
using Pharmacie.connexion;
using System.Collections.Generic;

namespace Pharmacie.controleur
{
    public class Controle
    {
        private const string connectionString = "mongodb://adminpharmacie:pwdadminpharmacie@127.0.0.1:27017";
        private const string dataBase = "pharmacie";
        private const string nomColRecommandations = "recommandations";
        private const string nomColMedicaments = "medicaments";
        private readonly ConnexionBdd connexionBDD;

        /// <summary>
        /// Constructeur : récupère l'instance pour la connection à la BDD et ouvre la fenêtre
        /// </summary>
        public Controle()
        {
            this.connexionBDD = ConnexionBdd.GetInstance(connectionString, dataBase);
            FrmPharmacie frmPharmacie = new FrmPharmacie(this);
            frmPharmacie.ShowDialog();
        }

        /// <summary>
        /// Récupère la liste des médicaments dans la BDD
        /// </summary>
        /// <returns>liste de médicaments</returns>
        public List<Medicament> GetMedicaments()
        {
            return connexionBDD.CollectionToList<Medicament>(nomColMedicaments);
        }

        /// <summary>
        /// Récupère la liste des recommandations dans la BDD
        /// </summary>
        /// <returns>liste des recommandations</returns>
        public List<Recommandation> GetRecommandations()
        {
            return connexionBDD.CollectionToList<Recommandation>(nomColRecommandations);
        }

        /// <summary>
        /// Demande d'ajout d'un médicament dans la BDD
        /// </summary>
        /// <param name="medicament"></param>
        public void AjoutMedicament(string nom, string libelle, string forme, string recommandation)
        {
            Medicament medicament = new Medicament(nom, libelle, forme, recommandation);
            connexionBDD.Ajout<Medicament>(nomColMedicaments, medicament);
        }

        /// <summary>
        /// Demande de suppression d'un médicament de la BDD
        /// </summary>
        /// <param name="medicament"></param>
        public void SupprMedicament(Medicament medicament)
        {
            connexionBDD.Suppr<Medicament>(nomColMedicaments, medicament.Id);
        }
    }
}
