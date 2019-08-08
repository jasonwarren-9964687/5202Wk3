using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int finish = 10;

            Console.WriteLine("For Loop");
            Console.WriteLine("N, 10N, 100N, 1000N");
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine((i)+", "+(i*10)+", "+(i*100)+", "+(i*1000));
            }
            Console.WriteLine("While Loop");
            int start2 = start;
            while (start2<=finish)
            {
                Console.WriteLine((start2) + ", " + (start2 * 10) + ", " + (start2 * 100) + ", " + (start2 * 1000));
                start2++;
            }
            Console.WriteLine("Do Loop");
            int start3 = start;
            do
            {
                Console.WriteLine((start3) + ", " + (start3 * 10) + ", " + (start3 * 100) + ", " + (start3 * 1000));
                start3++;
            } while (start3 <= finish);
            Console.ReadLine();
        }
    }
}
