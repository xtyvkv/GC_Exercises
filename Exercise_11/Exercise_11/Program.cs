int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
bool goAgain = true;
while (goAgain == true)
{
    Console.WriteLine("Here are all of the whole numbers from 0 to 9:");
    Console.WriteLine($"{numArray[0]} {numArray[1]} {numArray[2]} {numArray[3]} {numArray[4]} {numArray[5]} {numArray[6]} {numArray[7]} {numArray[8]} {numArray[9]}");
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

// better solution for invalid answer than exercise 10, but still can improve. see notes on exercise 10.
