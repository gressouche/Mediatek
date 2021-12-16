using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Livre : Document
    {
        private string isbn;
        private string auteur;
        private string laCollection;


        public Livre(string unId, string unTitre, string unISBN, string unAuteur, string uneCollection,string uneImage) : base(unId, unTitre, uneImage)
        {
            isbn = unISBN;
            auteur = unAuteur;
            laCollection = uneCollection;
        }

        public string ISBN { get => isbn; set => isbn = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string LaCollection { get => laCollection; set => laCollection = value; }
    }
}
