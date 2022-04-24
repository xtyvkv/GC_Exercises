Console.WriteLine("I would like you to enter 2 numbers. Enter your first number.");
string userNum1 = Console.ReadLine();
double userNum1Double;
if (Double.TryParse(userNum1, out userNum1Double))
{
    Console.WriteLine("Enter your second number.");
    string userNum2 = Console.ReadLine();
    double userNum2Double;
    if (Double.TryParse(userNum2, out userNum2Double))
    {
        Console.WriteLine($"{userNum1Double} * {userNum2Double} = " + (userNum1Double * userNum2Double));
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