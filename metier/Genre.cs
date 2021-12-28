using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86
{
    class Genre
    {
        public Genre(string unId, string unLibelle)
        {
            IdGenre = unId;
            Libelle = unLibelle;
        }

        public string IdGenre { get; set; }
        public string Libelle { get; set; }
    }





}
