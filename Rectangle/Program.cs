using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Character.");
            string c = Console.ReadLine();
            Console.WriteLine("Input width number.");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Input height number.");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("I AM A GOD");
            int track = 1;

            for (int b = track; b <= height; b++)
            {
                for (int i = track; i <= width; i++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
