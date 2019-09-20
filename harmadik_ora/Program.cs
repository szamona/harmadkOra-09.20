using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadik_ora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int max = 0;
            int min = 0;
            int db = 0;

            Console.WriteLine("Kérem adja meg a darab számot:");
            db = Convert.ToInt32(Console.ReadLine());
            int[] szam = new int[db]; 

            for (int i = 0; i < db; i++)
            {
                Console.WriteLine("Kérem adjon meg egy számot: ");
                szam[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < db; i++)
            {
                if (szam[max]<szam[i])
                {
                    max = i;
                }
                if (szam[min]<szam[i])
                {
                    min = i;
                }
            }
            Console.WriteLine("A legnagyobb szám a: "+szam[max]);
            Console.WriteLine("A legnkisebb szám a: " + szam[min]);
            Console.ReadLine();
        }
    }
}
