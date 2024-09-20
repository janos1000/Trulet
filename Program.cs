using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terulet
{
    internal class Program
    {
        static void terulet()
        {
            Console.WriteLine("Téglalap területének számítása.");

            int a;
            int b;
            int T;

            do
            {
                Console.WriteLine("Kérem 'a' oldal értékét (0 > kell lennie): ");
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);

            do
            {
                Console.WriteLine("Kérem 'b' oldal értékét (0 > kell lennie): ");
                b = int.Parse(Console.ReadLine());
            } while (b <= 0);
            
            T = a * b;

            Console.WriteLine($"A téglalap területe: {T}");

        }
        static void Main(string[] args)
        {
            terulet ();
        }
    }
}
