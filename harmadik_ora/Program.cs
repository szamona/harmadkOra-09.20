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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kérem adjon meg egy számot: ");
                szam[i] = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
