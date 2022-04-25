var inputList = new List<int>();
bool goAgain = true;
while (goAgain == true)
{
    Console.WriteLine("Please enter a number. I will calculate the sum of all the numbers from 1 to the number you have entered.");
    string input = Console.ReadLine();
    int inputInt = int.Parse(input);
    // TO DO: deal with invalid input
    for (int i = 0; i < inputInt; i++)
    {
        inputList.Add(i + 1);
    }
    int[] inputListArray = inputList.ToArray();
    int sum = inputListArray.Sum();
    Console.WriteLine(sum);
    Console.WriteLine();
    Console.WriteLine("Would you like to go again (y/n)?");
    string goAgainAnswer = Console.ReadLine();
    // TO DO: try out ignoring case
    if (goAgainAnswer == "y" || goAgainAnswer == "Y")
    {
        Console.WriteLine();
        continue;
    }
    else if (goAgainAnswer == "n" || goAgainAnswer == "N")
    {
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input.");
        break;
    }
}
Console.WriteLine();
Console.WriteLine("Goodbye!");