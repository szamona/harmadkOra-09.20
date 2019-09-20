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
            int[] szam = new int[10];
            int max = 0;
            int db = 0;

            Console.WriteLine("Kérem adja meg a darab számot:");
            db = Convert.ToInt32(Console.ReadLine());

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
            }
            Console.WriteLine("A legnagyobb szám a: "+szam[max]);
            
        }
    }
}
