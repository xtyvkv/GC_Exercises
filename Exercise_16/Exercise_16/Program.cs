using System;

namespace Exercise_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("OOOhhh I'm gunna make a silly RIGHT triangle 10 lines tall weeeee!!!!!");

            z = 10;

            for (x = 1; x <= z; x++)
            {
                // put y at 1 so it does 10 instead of 9
                for (y = 1; y <= x; y++)
                    Console.Write("*");
                Console.WriteLine("\n");
            }
        }
    }
}