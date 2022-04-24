Console.WriteLine("Please enter a number.");
string userNumberAnswer = Console.ReadLine();
int userNumberInt;
if (int.TryParse(userNumberAnswer, out userNumberInt))
{
    Console.WriteLine(userNumberInt + 1);
}
else
{
    Console.WriteLine("That is not a number.");
}
// path test fot github