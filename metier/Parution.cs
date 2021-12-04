using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Parution
    {
        private int numero;
        private DateTime dateParution;
        private string photo;
        private Titre titre;

        public Parution(int numero, DateTime dateParution, Titre unTitre, string photo)
        {
            this.Numero = numero;
            this.DateParution = dateParution;
            this.titre = unTitre;
            this.Photo = photo;
        }

        public int Numero { get => numero; set => numero = value; }
        public DateTime DateParution { get => dateParution; set => dateParution = value; }
        public string Photo { get => photo; set => photo = value; }
    }
}
