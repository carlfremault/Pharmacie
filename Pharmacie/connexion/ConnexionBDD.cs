﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pharmacie.connexion
{
    /// <summary>
    /// Classe de connexion à MongoDB
    /// </summary>
    public class ConnexionBdd
    {
        private readonly MongoClient client;
        private IMongoDatabase db;
        private static ConnexionBdd instance;

        /// <summary>
        /// Constructeur privé : connexion à MongoDB et accès à la base de données
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="dataBase"></param>
        private ConnexionBdd(string connectionString, string dataBase)
        {
            try
            {
                client = new MongoClient(connectionString);
                db = client.GetDatabase(dataBase);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        /// <summary>
        /// Création de l'instance unique de la classe
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="dataBase"></param>
        /// <returns></returns>
        public static ConnexionBdd GetInstance(string connectionString, string dataBase)
        {
            if (instance is null)
            {
                instance = new ConnexionBdd(connectionString, dataBase);
            }
            return instance;
        }

        /// <summary>
        /// Ajour d'un document dans une collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nomCollection"></param>
        /// <param name="document"></param>
        public void Ajout<T>(string nomCollection, T document)
        {
            GetCollection<T>(nomCollection).InsertOne(document);
        }

        /// <summary>
        /// Suppresion d'un document dans une collection, à partir de son id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nomCollection"></param>
        /// <param name="id"></param>
        public void Suppr<T>(string nomCollection, ObjectId id)
        {
            FilterDefinition<T> filter = Builders<T>.Filter.Eq("Id", id);
            GetCollection<T>(nomCollection).DeleteOne(filter);
        }

        /// <summary>
        /// Récupération d'une collection au format List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nomCollection"></param>
        /// <returns></returns>
        public List<T> CollectionToList<T>(string nomCollection)
        {
            return GetCollection<T>(nomCollection).AsQueryable().ToList<T>();
        }

        /// <summary>
        /// Récupération d'une collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nomCollection"></param>
        /// <returns></returns>
        private IMongoCollection<T> GetCollection<T>(string nomCollection)
        {
            return db.GetCollection<T>(nomCollection);
        }
    }
}
