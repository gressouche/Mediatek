using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Exemplaire
    {
        private int numero;
        private DateTime dateAchat;
        private string photo;
        private Document document;
        private Etat etat;

        public Exemplaire(int numero, DateTime dateAchat, string photo)
        {
            this.numero = numero;
            this.dateAchat = dateAchat;
            this.photo = photo;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Photo { get => photo; set => photo = value; }
        public DateTime DateAchat { get => dateAchat; set => dateAchat = value; }
        internal Document Document { get => document; set => document = value; }
        internal Etat Etat { get => etat; set => etat = value; }
    }
}
