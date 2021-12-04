using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Titre
    {
        private string idTitre;
        private string nom;
        private char empruntable;
        private Domaine domaine;

        public Titre(string idTitre, string nom, char empruntable, Domaine unDomaine)
        {
            this.IdTitre = idTitre;
            this.Nom = nom;
            this.Empruntable = empruntable;
            Domaine = unDomaine;
        }

        public Titre(string idTitre, string nom, char empruntable)
        {
            this.IdTitre = idTitre;
            this.Nom = nom;
            this.Empruntable = empruntable;
        }
        public string IdTitre { get => idTitre; set => idTitre = value; }
        public string Nom { get => nom; set => nom = value; }
        public char Empruntable { get => empruntable; set => empruntable = value; }
        internal Domaine Domaine { get => domaine; set => domaine = value; }
    }
}
