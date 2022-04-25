bool tallEnough = false;
bool goAgain = true;
while (tallEnough == false)
{
    Console.WriteLine("Welcome to the Coaster of Hell. To see if you are eligible to ride, please enter your height in inches.");
    string riderHeight = Console.ReadLine();
    int riderHeightInt = Convert.ToInt32(riderHeight);
    if (riderHeightInt < 54)
    {
        Console.WriteLine();
        Console.WriteLine($"Sorry, you cannot ride the Coaster of Hell. You need to be {54 - riderHeightInt} more inches tall.");
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
            Console.WriteLine("Goodbye!");
            break;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid answer. Let's try again.");
            Console.WriteLine();
            continue;
        }
    }
    else
    {
        tallEnough = true;
        Console.WriteLine();
        Console.WriteLine("Great, you can ride the Coaster of Hell!");
        Console.WriteLine("Have fun! Bye!");
        break;
    }
}

// TO DO
// work out more advanced invalid input response with option to try again or not
// logic if entered height is not an integer