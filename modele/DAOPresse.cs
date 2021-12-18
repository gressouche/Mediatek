using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mediatek86.metier;

namespace Mediatek86.bdd
{
    class DAOPresse
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

        /*public static List<Exemplaire> getParutionByTitre(Revue pTitre)
        {
            List<Exemplaire> lesParutions = new List<Exemplaire>();
            string req = "Select * from parution where idTitre = " + pTitre.IdTitre;

            DAOConnexion.connecter();

            MySqlDataReader reader = DAOConnexion.execSQLRead(req);

            while (reader.Read())
            {
                Exemplaire parution = new Exemplaire(int.Parse(reader[1].ToString()), DateTime.Parse(reader[2].ToString()),pTitre,reader[3].ToString());
                lesParutions.Add(parution);
            }
            DAOConnexion.deconnecter();
            return lesParutions;
        }*/


        // Crée dans la BDD l'objet CompteBancaire passé en paramètre
        /*public static void creerCompte(CompteBancaire unCompte)
        {
            string requete = "insert into compte_GRE values('" + unCompte.NumCompte + "','" +
                unCompte.NomTitulaire + "','" + unCompte.SoldeCompte.ToString() + "')";
            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }*/

        // Modifie dans la BDD le solde de l'objet CompteBancaire passé en paramètre
        /*public static void modifierCompte(CompteBancaire unCompte)
        {
            string requete = "update compte_GRE set solde=" + unCompte.SoldeCompte + " where numero='" + unCompte.NumCompte + "'";

            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }*/
    }
}

