Console.WriteLine("Huvudmeny");
Console.WriteLine("Skriv in siffror för att välja ett alternativ:")

while (true)
{
    Console.WriteLine("1. Alternativ 1");
    Console.WriteLine("2. Alternativ 2");
    Console.WriteLine("3. Avsluta");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("Du valde alternativ 1");
    }
    else if (input == "2")
    {
        Console.WriteLine("Du valde alternativ 2");
    }
    else if (input == "3")
    {
        Console.WriteLine("Avslutar programmet...");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt val, försök igen.");
    }
}