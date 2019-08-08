using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Highest Number.");
            int numb = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Lowest Number.");
            int finish = int.Parse(Console.ReadLine());

            Console.WriteLine("While Loop");
            int start = numb;
            while (finish <= start)
            {
                if (start % 2 != 0)

                    Console.WriteLine(start);
                    start--;
            }
            Console.ReadLine();
        }
    }
}
