using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tborai
{
    internal class pilota
    {

        public int ev { get; set; }
        public string nev { get; set; }
        public string szuletesidatum { get; set; }
        public string nemzet { get; set; }
        public int rszam { get; set; }

        public Pilota(string sor)
        {
            var adat = sor.Split(';');
            nev = adat[0];
            szuletesidatum = adat[1];
            ev = int.Parse(adat[1].Substring(0, 4));
            rszam = (adat[3].Length > 0) ? int.Parse(adat[3]) : 0;
            nemzet = adat[2];
        }
    }
}
