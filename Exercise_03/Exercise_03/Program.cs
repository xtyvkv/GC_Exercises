Console.WriteLine("Enter a number.");
string userInput = Console.ReadLine();
double userDouble;
if (double.TryParse(userInput, out userDouble))
{
    Console.WriteLine(userDouble + .5);
}
else
{
    Console.WriteLine("That is not a number.");
}
