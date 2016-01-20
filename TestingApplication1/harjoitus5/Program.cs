using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjoitus5
{
    class Program
    {
        static void Main(string[] args)
            
        {
            
            Console.WriteLine("Anna aika sekunteina: ");
            string line= Console.ReadLine();
            int aika = int.Parse(line);
            int tunnit = aika / 3600;
            int minuutit = aika / 60 - tunnit * 60;
            int sekunnit = aika % 60;
            Console.WriteLine("Tunnit:");
            Console.WriteLine(tunnit);
            Console.WriteLine("Minuutit:");
            Console.WriteLine(minuutit);
            Console.WriteLine("Sekunnit");
            Console.WriteLine(sekunnit);
            

        }
    }
}
