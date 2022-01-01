using System;

namespace Mediatek86.metier
{
    class Exemplaire
    {
        public Exemplaire(int numero, DateTime dateAchat, string photo,string etat)
        {
            this.Numero = numero;
            this.DateAchat = dateAchat;
            this.Photo = photo;
            this.IdEtat = etat;
        }

        public int Numero { get; set; }
        public string Photo { get; set; }
        public DateTime DateAchat { get; set; }
        internal Document Document { get; set; }
        public string IdEtat { get; set; }
    }
}
