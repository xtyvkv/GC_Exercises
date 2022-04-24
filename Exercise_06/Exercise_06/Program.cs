bool goAgain = true;
// string input;

while (goAgain)
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string input = Console.ReadLine();
    if (input == "y" || input == "Y")
    {
        goAgain = true;
    }
    else if (input == "n" || input == "N")
    {
        goAgain = false;
        Console.WriteLine("Goodbye!");
    }
    else
    {
        goAgain = false;
        Console.WriteLine("Invalid input. Goodbye!");
        // try asking to again again after invalid input, without repeating "Hello, World!"
    }
}