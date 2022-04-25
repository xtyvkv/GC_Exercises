int languageNo = 0;
bool goAgain = true;

Console.WriteLine("Translate \"Hello, World!\" into any language!");
Console.WriteLine();

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
    else if (string.Equals(language, "french", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 3;
    }
    else if (string.Equals(language, "russian", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 4;
    }
    else if (string.Equals(language, "german", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 5;
    }
    else if (string.Equals(language, "italian", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 6;
    }
    else if (string.Equals(language, "japanese", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 7;
    }
    else if (string.Equals(language, "chinese", StringComparison.InvariantCultureIgnoreCase))
    {
        languageNo = 8;
    }
    else
    {
        languageNo = 9;
    }
    Console.WriteLine();
    switch (languageNo)
    {
        case 0: //english
            Console.WriteLine("Hello, World!");
            break;
        case 1: //spanish
            Console.WriteLine("Hola, Mundo!");
            break;
        case 2: // dutch
            Console.WriteLine("Hallo, Wereld!");
            break;
        case 3: // french
            Console.WriteLine("Bonjour le monde!");
            break;
        case 4: // russian
            // Console.WriteLine("Привет, мир! (Privet, mir!)");
            Console.WriteLine("Privet, mir!");
            break;
        case 5: // german
            Console.WriteLine("Hallo Welt!");
            break;
        case 6: // italian
            Console.WriteLine("Ciao mondo!");
            break;
        case 7: // japanese 
            // Console.WriteLine("こんにちは世界！ (Kon'nichiwa sekai!)");
            Console.WriteLine("Kon'nichiwa sekai!");
            break;
        case 8: // chinese
            // Implement "Did you mean Mandarin or Cantonese?"
            // Console.WriteLine("Simplified: 你好世界！ (Nǐ hǎo shìjiè!)\nTraditional: 你好世界！ (Nǐ hǎo shìjiè!)");
            Console.WriteLine("Simplified: Nǐ hǎo shìjiè!\nTraditional: Nǐ hǎo shìjiè!");
            break;
        case 9:
            goAgain = false;
            Console.WriteLine("I don't know that language.");
            break;

    }
    Console.WriteLine();
    Console.WriteLine("Would you like to continue (y/n?)");
    string plzContinue = Console.ReadLine();
    if (plzContinue == "y" || plzContinue == "Y")
    {
        Console.WriteLine();
        continue;
    }
    else if (plzContinue == "n" || plzContinue == "N")
    {
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input.");
        Console.WriteLine("Goodbye!");
        break;
    }
}
