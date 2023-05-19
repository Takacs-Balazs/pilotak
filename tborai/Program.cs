using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace tborai
{
    class Program
    {
        static void Main()
        {
            List<pilota> adatok = new List<pilota>();
            StreamReader sr = new StreamReader("pilotak.csv");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {string[] adat = sr.ReadLine().Split(';');
                adatok.Add(new pilota(adat[0],adat[1],adat[2],(adat[3].Length>0)?int.Parse(adat[3]):0));} sr.Close(); ;
            Console.WriteLine($"3.feladat:{adatok.Count()}");
            Console.WriteLine($"4.feladat:{adatok.Last().Nev}");
            Console.WriteLine($"5.feladat:");
            Console.WriteLine($"6.feladat: {adatok.Where(seged => seged.Rajtszam != 0).OrderBy(seged => seged.Rajtszam).First().Nemzetiseg}");
            Console.WriteLine($"7.feladat:");


        }
    }
}