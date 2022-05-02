// clean up continuation

using System;

namespace Exercise_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;

            while (goAgain)
            {
                Console.Write("Please enter a number >> ");
                string input;
                int inputInt;
                input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    goAgain = false;
                else
                {
                    inputInt = Convert.ToInt32(input);
                    for (int i = 1; i < inputInt + 1; i++)
                    {
                        Console.WriteLine($"{i} * {i} = {i * i}");
                    }
                    Console.WriteLine();
                    Console.Write("Would you like to continue (y/n)? >> ");
                    var goAgainInput = Console.ReadLine();
                    if (goAgainInput == "y")
                    {
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        break;
                    }
                }
            }
            Console.WriteLine("Bye!");
        }
    }
}
