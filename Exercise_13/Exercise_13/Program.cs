bool goAgain = true;
while (goAgain == true)
{
    Console.WriteLine("Enter a number.");
    string input = Console.ReadLine();
    int inputInt = int.Parse(input);
    Console.WriteLine();
    for (int i = inputInt; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue (y/n)?");
    string goAgainAnswer = Console.ReadLine();
    if (goAgainAnswer == "y" || goAgainAnswer == "Y")
    {
        Console.WriteLine();
        continue;
    }
    else if (goAgainAnswer == "n" || goAgainAnswer == "N")
    {
        Console.WriteLine();
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Invalid answer.");
        break;
    }
}
Console.WriteLine("Goodbye!");

// same thing with exercise 11 and 12...done but figure out that thing.