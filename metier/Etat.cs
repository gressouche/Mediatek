﻿

namespace Mediatek86.metier
{
    class Etat
    {
        public Etat(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public string Id { get; set; }
        public string Libelle { get; set; }
    }
}
