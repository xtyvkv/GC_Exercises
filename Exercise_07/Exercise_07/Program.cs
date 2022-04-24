bool goAgain = true;
// i thought without saying true it assumes true^?

while(goAgain)
{
    Console.WriteLine("Enter some text:");
    string someText = Console.ReadLine();
    Console.WriteLine(someText);
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
        // try asking to again again after invalid input, without repeating "Hello, World!"
    }
}    
