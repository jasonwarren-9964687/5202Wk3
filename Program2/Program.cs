using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number.");
            int start = 1;
            int numb = int.Parse(Console.ReadLine());
            int finish = 12;

            Console.WriteLine("For Loop");
            Console.WriteLine("N, 10N, 100N, 1000N");
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine($"{i}x{numb}={i * numb}");
            }
            Console.WriteLine("While Loop");
            int start2 = start;
            while (start2 <= finish)
            {
                Console.WriteLine($"{start2}x{numb}={start2 * numb}");
                start2++;
            }
            Console.WriteLine("Do Loop");
            int start3 = start;
            do
            {
                Console.WriteLine($"{start3}x{numb}={start3 * numb}");
                start3++;
            } while (start3 <= finish);
            Console.ReadLine();
        }
    }
}
