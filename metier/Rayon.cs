

namespace Mediatek86.metier
{
    class Rayon
    {
        public Rayon(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public string Id { get; set; }
        public string Libelle { get; set; }
    }
}
