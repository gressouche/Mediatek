using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mediatek86.bdd
{
    class DAOConnexion
    {
        private static MySqlConnection connexion;

        /// <summary>
        /// Crée l'objet Connection pour lier le programme à la base de données
        /// </summary>
        public static void creerConnection()
        {
            string serverIp = "127.0.0.1";
            string username = "root";
            string password = "";
            string databaseName = "mediatek86";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);

            try
            {
                connexion = new MySqlConnection(dbConnectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur connexion BDD", e.Message);
                Application.Exit();
            }

        }

        /// <summary>
        /// Ouvre la connection pour permettre une requête SQL
        /// </summary>
        public static void connecter()
        {
            try
            {
                connexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur ouverture connection BDD -" + e.Message);
            }
        }

        /// <summary>
        /// Ferme la connection dès que la requête est faire
        /// </summary>
        public static void deconnecter()
        {
            connexion.Close();
        }

        /// <summary>
        /// Exécute une requête d'interrogation de la base de données
        /// </summary>
        /// <param name="requete">Requête SQL sous forme de chaîne de caractères</param>
        /// <returns>Le résultat de la requête sous forme de dataReader</returns>
        public static MySqlDataReader execSQLRead(string requete)
        {
            MySqlDataReader dataReader = null;
            try
            {
                MySqlCommand command;
                MySqlDataAdapter adapter;
                command = new MySqlCommand();
                command.CommandText = requete;
                command.Connection = connexion;

                adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;

                dataReader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur exécution SQL lecture -" + e.Message);
            }

            return dataReader;
        }

        /// <summary>
        /// Exécute une requete d'écriture (Insert ou Update) ; ne retourne rien
        /// </summary>
        /// <param name="requete">Requête SQL sous forme de chaîne de caractères</param>
        public static void execSQLWrite(string requete)
        {
            try
            {
                MySqlCommand command;
                command = new MySqlCommand();
                command.CommandText = requete;
                command.Connection = connexion;

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur exécution SQL écriture -" + e.Message);
            }
        }
    }
}
