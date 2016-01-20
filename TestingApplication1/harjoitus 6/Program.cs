using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Käyttäjältä kysytään matkaa
            Console.WriteLine("Anna matka kilometreinä:");
            string line = Console.ReadLine();
            // määritetään arvot
            double matka = int.Parse(line);
            double perkilometri = 0.0702;
            double kulutus = matka * perkilometri;
            double hinta = 1.595;
            double kustannus = hinta * kulutus;
            Console.WriteLine("Bensaa kului: {0:F2} litraa", kulutus);
            Console.WriteLine("Matkan hinnaksi tuli: {0:F2} euroa", kustannus);
        }
    }
}
