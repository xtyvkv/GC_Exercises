bool goAgain = true;
while (goAgain == true)
{
    Console.WriteLine("Counting down from 9 to 0...");
    var cool = 9;
    for (int i = -1; i < 9; i++)
    {
        Console.WriteLine(cool--);
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
// use for to count inline in 1 string?
// does this involve Char and count and stuff?