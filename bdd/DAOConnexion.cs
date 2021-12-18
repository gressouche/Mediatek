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
        private static MySqlDataReader reader;

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



        /// <summary>
        /// Exécute une requête type "select" et valorise le curseur
        /// </summary>
        /// <param name="stringQuery">requête select</param>
        public static void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            MySqlCommand command;
            
            try
            {
                command = new MySqlCommand(stringQuery, connexion);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Tente de lire la ligne suivante du curseur
        /// </summary>
        /// <returns>false si fin de curseur atteinte</returns>
        public static bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Retourne le contenu d'un champ dont le nom est passé en paramètre
        /// </summary>
        /// <param name="nameField">nom du champ</param>
        /// <returns>valeur du champ</returns>
        public static object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

    }
}
