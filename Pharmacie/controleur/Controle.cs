using Pharmacie.modele;
using Pharmacie.vue;
using Pharmacie.connexion;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace Pharmacie.controleur
{
    public class Controle
    {
        private string connectionString = null;
        private string pwd = null;
        private const string dataBase = "pharmacie";
        private const string nomColRecommandations = "recommandations";
        private const string nomColMedicaments = "medicaments";
        private readonly ConnexionBdd connexionBDD;

        private string GetPwd()
        {
            try
            {
                return System.IO.File.ReadAllText("pwd.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
            return null;
        }

        /// <summary>
        /// Création de la chaîne de connexiion
        /// </summary>
        /// <returns></returns>
        private string Connection()
        {
            if (pwd is null)
            {
                pwd = GetPwd();
            }
            if (connectionString is null)
            {
                connectionString = "mongodb://adminpharmacie:" + pwd + "@127.0.0.1:27017";
            }
            return connectionString;
        }

        /// <summary>
        /// Constructeur : récupère l'instance pour la connection à la BDD et ouvre la fenêtre
        /// </summary>
        public Controle()
        {
            this.connexionBDD = ConnexionBdd.GetInstance(Connection(), dataBase);
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
