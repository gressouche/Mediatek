using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mediatek86.bdd
{
    static class DaoConnexion
    {
        private static MySqlConnection connexion;
        private static MySqlDataReader reader;

        /// <summary>
        /// Crée l'objet Connection pour lier le programme à la base de données
        /// </summary>
        public static void creerConnection()
        {
            string serverIp = "127.0.0.1";
            string username = "mediatek";
            string password = "q5OJ7QUAKHeBN3xe";
            string databaseName = "mediatek86";

            string dbConnectionString = string.Format("server={0};uid={1};pwd={2};database={3};", serverIp, username, password, databaseName);

            try
            {
                connexion = new MySqlConnection(dbConnectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur connexion BDD" + ex.Message);
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


        /// <summary>
        /// Exécution d'une requête autre que "select"
        /// </summary>
        /// <param name="stringQuery">requête autre que select</param>
        /// <param name="parameters">dictionnire contenant les parametres</param>
        public static void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
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
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
