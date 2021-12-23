using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Revue : Document
    {
        public Revue(string unId, string unTitre, string uneImage, char unEmpruntable, string unePeriodicite, int unDelai)
             : base(unId, unTitre, uneImage)
        {
            Periodicite = unePeriodicite;
            Empruntable = unEmpruntable;
            DelaiMiseADispo = unDelai;
        }

        public Document getInstanceDocument()
        {
            return base.getInstance();
        }

        public string Periodicite { get; set; }
        public char Empruntable { get; set; }
        public int DelaiMiseADispo { get; set; }
    }
}
