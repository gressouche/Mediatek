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


        public Livre(string unId, string unTitre, string unISBN, string unAuteur) : base(unId, unTitre)
        {
            ISBN = unISBN;
            auteur = unAuteur;
        }
    }
}
