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
        private string image;
        private Genre leGenre;
        private Categorie laCategorie;
        private Rayon leRayon;
      

        public Document(string unId, string unTitre, string uneImage)
        {
            idDoc = unId;
            titre = unTitre;
            image = uneImage;
        }


        public string IdDoc { get => idDoc; set => idDoc = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Image { get => image; set => image = value; }
        internal Genre LeGenre { get => leGenre; set => leGenre = value; }
        internal Categorie LaCategorie { get => laCategorie; set => laCategorie = value; }
        internal Rayon LeRayon { get => leRayon; set => leRayon = value; }
    }


}
