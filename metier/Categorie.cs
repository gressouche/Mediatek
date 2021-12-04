using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Categorie
    {
        private string idCategorie;
        private string libelle;


        public Categorie(string unId, string unLibelle)
        {
            IdCategorie = unId;
            Libelle = unLibelle;
        }

        public string IdCategorie { get => idCategorie; set => idCategorie = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
