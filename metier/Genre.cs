using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86
{
    class Genre
    {
        private string idGenre;
        private string libelle;

        public Genre(string unId, string unLibelle)
        {
            IdGenre = unId;
            Libelle = unLibelle;
        }

        public string IdGenre { get => idGenre; set => idGenre = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }





}
