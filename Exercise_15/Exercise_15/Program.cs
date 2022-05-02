using System;

namespace Exercise_15
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
                        Console.WriteLine($"{i}^3 = {i * i * i}");
                    }
                    Console.WriteLine();
                    Console.Write("Would you like to continue (y/n)? >> ");
                    var goAgainInput = Console.ReadLine();
                    // i know how to ignore case but it's 3am and i just wanna do these exercises
                    // do they want me to make a method to cube these?
                    if (goAgainInput == "y" || goAgainInput == "Y")
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