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


            using (StreamReader reader = new StreamReader("pilotak.csv"))
            {
                string fejlec = reader.ReadLine();  


                while (!reader.EndOfStream)
                {
                    string sor = reader.ReadLine();
                    string[] adatSor = sor.Split(';'); 

                    adatok.Add(adatSor);  
                }
            }

            int adatSorokSzama = adatok.Count;  

            Console.WriteLine("3. feladat: " + adatSorokSzama);
        }
    }
}