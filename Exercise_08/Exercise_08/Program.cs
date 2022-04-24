bool goAgain = true;

while (goAgain)
{
    Console.WriteLine("Let's add 1 to a number! Please enter a number.");
    string userNumberAnswer = Console.ReadLine();
    double userNumberInt;
    if (double.TryParse(userNumberAnswer, out userNumberInt))
    {
        Console.WriteLine($"{userNumberInt} + 1 = " + (userNumberInt + 1));
        // days deci is not number
    }
    else
    {
        Console.WriteLine("That is not a number.");
    }
    Console.WriteLine("Let's add .5 to a number! Please enter a number.");
    string userInput = Console.ReadLine();
    double userDouble;
    if (double.TryParse(userInput, out userDouble))
    {
        Console.WriteLine($"{userDouble} + .5 = " + (userDouble + .5));
    }
    else
    {
        Console.WriteLine("That is not a number.");
    }
    Console.WriteLine("Okay, let's add 2 numbers. Please enter the first number.");
    string userNum1Add = Console.ReadLine();
    double userNum1AddDouble;
    if (Double.TryParse(userNum1Add, out userNum1AddDouble))
    {
        Console.WriteLine("Enter the second number.");
        string userNum2Add = Console.ReadLine();
        double userNum2AddDouble;
        if (Double.TryParse(userNum2Add, out userNum2AddDouble))
        {
            Console.WriteLine($"{userNum1AddDouble} + {userNum2AddDouble} = " + (userNum1AddDouble + userNum2AddDouble));
        }
        else
        {
            Console.WriteLine("That is not a number.");
        }
    }
    else
    {
        Console.WriteLine("That is not a number.");
    }
    Console.WriteLine("Now lets multiply 2 numbers. Please enter the first number.");
    string userNum1Mult = Console.ReadLine();
    double userNum1MultDouble;
    if (Double.TryParse(userNum1Mult, out userNum1MultDouble))
    {
        Console.WriteLine("Enter the second number.");
        string userNum2Mult = Console.ReadLine();
        double userNum2MultDouble;
        if (Double.TryParse(userNum2Mult, out userNum2MultDouble))
        {
            Console.WriteLine($"{userNum1MultDouble} * {userNum2MultDouble} = " + (userNum1MultDouble * userNum2MultDouble));
        }
        else
        {
            Console.WriteLine("That is not a number.");
        }
    }
    else
    {
        Console.WriteLine("That is not a number.");
    }
    Console.WriteLine("Would you like to continue (y/n)?");
    string userWannaGo = Console.ReadLine();
    if (userWannaGo == "y" || userWannaGo == "Y")
    {
        goAgain = true;
    }
    else if (userWannaGo == "n" || userWannaGo == "N")
    {
        goAgain = false;
        Console.WriteLine("Goodbye!");
    }
    else
    {
        goAgain = false;
        Console.WriteLine("Invalid input. Goodbye!");
    }
}

