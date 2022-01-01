using System;
using System.Collections.Generic;
using Mediatek86.metier;

namespace Mediatek86.bdd
{
    static class DaoPresse
    {

        private static readonly string connectionString = "server=localhost;user id=mediatek;password=q5OJ7QUAKHeBN3xe;database=mediatek86;SslMode=none";
        /// <summary>
        /// Recherche du Genre d'après son identifiant
        /// </summary>
        /// <param name="pId">identifiant du genre</param>
        /// <returns>l'objet Genre trouvé</returns>
        public static Genre getGenreById(string pId)
        {
            Genre genre;
            string req = "Select * from genre where id = @id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pId }
            };

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                genre = new Genre((string)curs.Field("id"), (string)curs.Field("libelle"));
            }
            else
            {
                genre = null;
            }
            curs.Close();
            return genre;
        }

        /// <summary>
        /// Recherche le genre associé à une revue
        /// </summary>
        /// <param name="pRevue">la revue concernée</param>
        /// <returns>l'objet Genre de la Revue</returns>
        public static Genre getGenreByRevue(Revue pRevue)
        {
            Genre genre;

            string req = "Select g.id,g.libelle from genre g, document d where g.id = d.idgenre and d.id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pRevue.IdDoc }
            };

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            if (curs.Read())
            {
                genre = new Genre((string)curs.Field("id"), (string)curs.Field("libelle"));
            }
            else
            {
                genre = null;
            }
            curs.Close();
            return genre;
        }

        /// <summary>
        /// Recherche l'ensemble des revues
        /// </summary>
        /// <returns>une collection des objets Revue</returns>
        public static List<Revue> getLesRevues()
        {
            List<Revue> lesRevues = new List<Revue>();
            string req = "select r.id, titre, image, empruntable, periodicite, delaimiseadispo from revue r join document d on r.id = d.id order by titre";
            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, null);
            while (curs.Read())
            {
                Revue revue = new Revue((string)curs.Field("id"), (string)curs.Field("titre"), (string)curs.Field("image"), char.Parse((string)curs.Field("empruntable")), (string)curs.Field("periodicite"), (int)curs.Field("delaimiseadispo"));
                lesRevues.Add(revue);

            }
            curs.Close();
            return lesRevues;
        }

        /// <summary>
        /// Recherche les exemplaires d'une revue
        /// </summary>
        /// <param name="pRevue">la revue concernée</param>
        /// <returns>une collection des objets Exemplaire de la Revue</returns>
        public static List<Exemplaire> getLesExemplairesByRevue(Revue pRevue)
        {
            List<Exemplaire> lesExemplaires = new List<Exemplaire>();

            string req = "Select ex.numero,ex.dateAchat,ex.photo, et.id from exemplaire ex join etat et on et.id = ex.idEtat where ex.id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pRevue.IdDoc }
            };

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);

            while (curs.Read())
            {
                Exemplaire exemplaire = new Exemplaire(int.Parse(curs.Field("numero").ToString()), (DateTime)curs.Field("dateAchat"), (string)curs.Field("photo"), (string)curs.Field("id"));
                exemplaire.Document = pRevue.getInstanceDocument();
                lesExemplaires.Add(exemplaire);
            }

            curs.Close();
            return lesExemplaires;
        }

        /// <summary>
        /// ecriture d'un exemplaire en base de données
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire</param>
        public static void creerExemplaire(Exemplaire exemplaire)
        {
            string req = "insert into exemplaire values (@idDoc,@numero,@dateParution,@photo,@idEtat)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idDoc", exemplaire.Document.IdDoc},
                { "@numero", exemplaire.Numero},
                { "@dateParution", exemplaire.DateAchat},
                { "@photo", exemplaire.Photo},
                { "@idEtat",exemplaire.IdEtat}
            };

            DaoConnexion curs = DaoConnexion.GetInstance(connectionString);
            try
            {
                curs.ReqUpdate(req, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            curs.Close();
        }
    }
}

