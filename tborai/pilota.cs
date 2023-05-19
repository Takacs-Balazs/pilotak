using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tborai
{
    internal class pilota
    {
        string nev;
        string szuletes;
        string nemzetiseg;
        int rajtszam;

        public pilota(string nev, string szuletes, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szuletes = szuletes;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Szuletes { get => szuletes; set => szuletes = value; }
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public int Rajtszam { get => rajtszam; set => rajtszam = value; }
    }
}
