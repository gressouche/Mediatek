using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Livre : Document
    {
        private string ISBN;
        private string auteur;
        private string laCollection;


        public Livre(string unId, string unTitre, string unISBN, string unAuteur, string uneCollection,string uneImage) : base(unId, unTitre, uneImage)
        {
            ISBN1 = unISBN;
            Auteur = unAuteur;
            LaCollection = uneCollection;
        }

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string LaCollection { get => laCollection; set => laCollection = value; }
    }
}
