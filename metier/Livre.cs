using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Livre : Document
    {
        public Livre(string unId, string unTitre, string unISBN, string unAuteur, string uneCollection,string uneImage) : base(unId, unTitre, uneImage)
        {
            ISBN = unISBN;
            Auteur = unAuteur;
            LaCollection = uneCollection;
        }

        public string ISBN { get; set; }
        public string Auteur { get; set; }
        public string LaCollection { get; set; }
    }
}
