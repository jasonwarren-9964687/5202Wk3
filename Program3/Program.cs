using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int finish = 10;

            Console.WriteLine("Number, Square, Cube");
            Console.WriteLine("For Loop");
            
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine($"{i}, {i*i}, {i*i*i}");
            }
            Console.WriteLine("While Loop");
            int start2 = start;
            while (start2 <= finish)
            {
                Console.WriteLine($"{start2}, {start2 * start2}, {start2 * start2 * start2}");
                start2++;
            }
            Console.WriteLine("Do Loop");
            int start3 = start;
            do
            {
                Console.WriteLine($"{start3}, {start3 * start3}, {start3 * start3 * start3}");
                start3++;
            } while (start3 <= finish);
            Console.ReadLine();
        }
    }
}
