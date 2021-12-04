using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediatek86.metier
{
    class Domaine
    {
        private string idDomaine;
        private string libelle;

        public Domaine(string pIdDomaine, string pLibelle)
        {
            this.idDomaine = pIdDomaine;
            this.libelle = pLibelle;
        }

        public string IdDomaine { get => idDomaine; set => idDomaine = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
