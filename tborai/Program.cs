using System;
using System.Collections.Generic;
using System.IO;

namespace tborai
{
    class Program
    {
        static void Main()
        {
            List<string[]> adatok = new List<string[]>();
            StreamReader sr = new StreamReader("pilotak.csv");
            sr.Close();
            while (!sr.EndOfStream)
            {string[] adat = sr.ReadLine().Split(';');
                pilota.Add(new Pilota(adat[0], adat[1], adat[2], (adat[3].Length > 0) ? int.Parse(adat[3]):0));}
            sr.Close ();
            Console.WriteLine($"3.feladat:{Pilotak.Count()}");
            Console.WriteLine($"4.feladat:");
            Console.WriteLine($"5.feladat:");
            Console.WriteLine($"6.feladat:");
            Console.WriteLine($"7.feladat:");


        }
    }
}