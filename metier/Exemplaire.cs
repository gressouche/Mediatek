using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Exemplaire
    {
        public Exemplaire(int numero, DateTime dateAchat, string photo,string etat)
        {
            this.Numero = numero;
            this.DateAchat = dateAchat;
            this.Photo = photo;
            this.Etat = etat;
        }

        public int Numero { get; set; }
        public string Photo { get; set; }
        public DateTime DateAchat { get; set; }
        internal Document Document { get; set; }
        public string Etat { get; set; }
    }
}
