using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Categorie
    {
        public Categorie(string unId, string unLibelle)
        {
            IdCategorie = unId;
            Libelle = unLibelle;
        }

        public string IdCategorie { get; set; }
        public string Libelle { get; set; }
    }
}
