using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderObject
{
    class Employe
    {
        public Int16 Numemp { get; set; }
        public String Nomemp { get; set; }
        public String Prenomemp { get; set; }
        public String Poste { get; set; }
        public String Salaire { get; set; }
        public Single? Prime { get; set; } // nullable
        public String CodeProjet { get; set; }
        public Int16? Superieur { get; set; } // nullable

        public override string ToString()
        {
            return Numemp + " . " + Nomemp + " . " + Prenomemp + " . " + Poste + " . " + Salaire + " . " + Prime + " . " + CodeProjet + " . " + Superieur;
        }
    }

}
