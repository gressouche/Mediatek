using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Etat
    {
        private string id;
        private string libelle;

        public Etat(string id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public string Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
