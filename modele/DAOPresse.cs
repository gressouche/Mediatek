using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mediatek86.metier;

namespace Mediatek86.bdd
{
    static class DaoPresse
    {
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

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, parameters);
            if (DaoConnexion.Read())
            {
                genre = new Genre((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("libelle"));
            }
            else
            {
                genre = null;
            }
            DaoConnexion.deconnecter();
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

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, parameters);

            if (DaoConnexion.Read())
            {
                genre = new Genre((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("libelle"));
            }
            else
            {
                genre = null;
            }
            DaoConnexion.deconnecter();
            return genre;
        }

        /// <summary>
        /// Recherche l'ensemble des revues
        /// </summary>
        /// <returns>une collection des objets Revue</returns>
        public static List<Revue> getLesRevues()
        {
            List<Revue> lesRevues = new List<Revue>();
            string req = "select r.id, titre, image, empruntable, periodicite, delaimiseadispo from revue r join document d on r.id = d.id";
            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, null);
            while (DaoConnexion.Read())
            {
                Revue revue = new Revue((string)DaoConnexion.Field("id"), (string)DaoConnexion.Field("titre"), (string)DaoConnexion.Field("image"), char.Parse((string)DaoConnexion.Field("empruntable")), (string)DaoConnexion.Field("periodicite"), (int)DaoConnexion.Field("delaimiseadispo"));
                lesRevues.Add(revue);

            }
            DaoConnexion.deconnecter();
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

            string req = "Select ex.numero,ex.dateAchat,ex.photo, et.libelle from exemplaire ex join etat et on et.id = ex.idEtat where ex.id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pRevue.IdDoc }
            };

            DaoConnexion.connecter();
            DaoConnexion.ReqSelect(req, parameters);

            while (DaoConnexion.Read())
            {
                Exemplaire exemplaire = new Exemplaire(int.Parse(DaoConnexion.Field("numero").ToString()), (DateTime)DaoConnexion.Field("dateAchat"), (string)DaoConnexion.Field("photo"), (string)DaoConnexion.Field("etat"));
                exemplaire.Document = pRevue.getInstanceDocument();
                lesExemplaires.Add(exemplaire);
            }

            DaoConnexion.deconnecter();
            return lesExemplaires;
        }

        /// <summary>
        /// ecriture d'un exemplaire en base de données
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire</param>
        public static void creerExemplaire(Exemplaire exemplaire)
        {
            string etat = null;
            switch (exemplaire.Etat)
            {
                case "neuf": { etat = "00001"; break; }
                case "usagé": { etat = "00002"; break; }
                case "détérioré": { etat = "00003"; break; }
                case "inutilisable": { etat = "00004"; break; }
            }
            string req = "insert into exemplaire values (@idDoc,@numero,@dateParution,@photo,@idEtat)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@idDoc", exemplaire.Document.IdDoc},
                { "@numero", exemplaire.Numero},
                { "@dateParution", exemplaire.DateAchat},
                { "@photo", exemplaire.Photo},
                { "@idEtat", etat}
            };
            DaoConnexion.connecter();
            try
            {
                DaoConnexion.ReqUpdate(req, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            DaoConnexion.deconnecter();
        }
    }
}

