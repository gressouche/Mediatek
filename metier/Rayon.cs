using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Rayon
    {
        private string id;
        private string libelle;

        public Rayon(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public string Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
