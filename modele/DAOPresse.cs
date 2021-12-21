using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mediatek86.metier;

namespace Mediatek86.bdd
{
    static class DAOPresse
    {
        public static Genre getGenreById(string pId)
        {
            Genre genre;
            string req = "Select * from genre where id = @id";          
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pId }
            };

            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, parameters);
            if (DAOConnexion.Read())
            {
                genre = new Genre((string)DAOConnexion.Field("id"), (string)DAOConnexion.Field("libelle"));
            }
            else
            {
                genre = null;
            }
            DAOConnexion.deconnecter();
            return genre;       
        }


        public static Genre getGenreByRevue(Revue pRevue)
        {
            Genre genre;

            string req = "Select g.id,g.libelle from genre g, document d where g.id = d.idgenre and d.id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pRevue.IdDoc }
            };
            
            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, parameters);

            if (DAOConnexion.Read())
            {
                genre = new Genre((string)DAOConnexion.Field("id"), (string)DAOConnexion.Field("libelle"));
            }
            else
            {
                genre = null;
            }
            DAOConnexion.deconnecter();
            return genre;
        }
        
        
        public static List<Revue> getLesRevues()
        {
            List<Revue> lesRevues = new List<Revue>();
            string req = "select r.id, titre, image, empruntable, periodicite, delaimiseadispo from revue r join document d on r.id = d.id";
            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, null);
            while (DAOConnexion.Read())
            {
                Revue revue = new Revue((string)DAOConnexion.Field("id"), (string)DAOConnexion.Field("titre"), (string)DAOConnexion.Field("image"), char.Parse((string)DAOConnexion.Field("empruntable")), (string)DAOConnexion.Field("periodicite"), (int)DAOConnexion.Field("delaimiseadispo") );
                lesRevues.Add(revue);

            }
            DAOConnexion.deconnecter();
            return lesRevues;
        }


        public static List<Exemplaire> getLesExemplairesByRevue(Revue pRevue)
        {
            List<Exemplaire> lesExemplaires = new List<Exemplaire>();

            string req = "Select ex.numero,ex.dateAchat,ex.photo, et.libelle from exemplaire ex join etat et on et.id = ex.idEtat where ex.id=@id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", pRevue.IdDoc }
            };

            DAOConnexion.connecter();
            DAOConnexion.ReqSelect(req, parameters);

            while (DAOConnexion.Read())
            {
                Exemplaire exemplaire = new Exemplaire(int.Parse(DAOConnexion.Field("numero").ToString()), (DateTime)DAOConnexion.Field("dateAchat"), (string)DAOConnexion.Field("photo"), (string)DAOConnexion.Field("etat"));
                exemplaire.Document = pRevue.getInstanceDocument(); ;
                lesExemplaires.Add(exemplaire);
            }
            
            DAOConnexion.deconnecter();
            return lesExemplaires;
        }
    
    
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
            DAOConnexion.connecter();
            try
            {
DAOConnexion.ReqUpdate(req, parameters);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            DAOConnexion.deconnecter();
        }
    }
}

