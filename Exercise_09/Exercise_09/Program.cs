int languageNo = 0;
bool goAgain = true;

while (goAgain = true)
{
    Console.WriteLine("Enter a language.");
    string language = Console.ReadLine();
    if (string.Equals(language, "english", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 0;
    }
    else if (string.Equals(language, "spanish", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 1;
    }
    else if (string.Equals(language, "dutch", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 2;
    }
    else
    {
        languageNo = 3;
    }

    switch (languageNo)
    {
        case 0:
            Console.WriteLine("Hello, World!");
            break;
        case 1:
            Console.WriteLine("Hola, Mundo!");
            continue;
        case 2:
            Console.WriteLine("Hallo, Wereld!");
            Console.WriteLine("Would you like to continue (y/n?)");
            string plzContinue = Console.ReadLine();
            if (plzContinue == "y")
            {
                continue;
            }
            else
            {
                break;
            }
        case 3:
            goAgain = false;
            Console.WriteLine("Goodbye!");
            Console.WriteLine("I don't know that language.");
            break;
            // this is wrong. but i have to put a pin here.

    }
}

// is there a built in translator?
