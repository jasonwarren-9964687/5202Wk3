using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Character.");
            string c = Console.ReadLine();
            Console.WriteLine("Input number.");
            int numb = int.Parse(Console.ReadLine());

            Console.WriteLine("For Loop");
            int track = 1;

            for (int i = track; i <= numb; i++)
            {
                Console.Write(c);
            }
            Console.ReadLine();
        }
    }
}
