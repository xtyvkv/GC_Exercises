using System;

namespace Exercise_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("OOOhhh I'm gunna make a silly triangle 10 lines tall weeeee!!!!!");

            z = 10;

            for (x = 0; x <= z; x++)
            {
                // adding a space each time to offset the lines to make a cool triangle
                for (y = 1; y <= z - x; y++)
                    Console.Write(" ");
                for (y = 1; y <= 2 * x - 1; y++)
                    Console.Write("*");
                Console.WriteLine("\n");
            }
        }
    }
}