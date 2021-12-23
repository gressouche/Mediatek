using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Document
    {
        public Document(string unId, string unTitre, string uneImage)
        {
            IdDoc = unId;
            Titre = unTitre;
            Image = uneImage;
        }

        public string IdDoc { get; set; }
        public string Titre { get; set; }
        public string Image { get; set; }
        internal Genre LeGenre { get; set; }
        internal Categorie LaCategorie { get; set; }
        internal Rayon LeRayon { get; set; }

        public Document getInstance()
        {
            return this;
        }
    }


}
