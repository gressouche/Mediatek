using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Document
    {
        private string idDoc;
        private string titre;
        private Genre leGenre;
        private Categorie laCategorie;

        public Document(string unId,string unTitre)
        {
            idDoc = unId;
            titre = unTitre;
        }


        public string IdDoc { get => idDoc; set => idDoc = value; }
        public string Titre { get => titre; set => titre = value; }
        internal Genre LeGenre { get => leGenre; set => leGenre = value; }
        internal Categorie LaCategorie { get => laCategorie; set => laCategorie = value; }
    }


}
