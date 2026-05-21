Console.WriteLine("Huvudmeny");
Console.WriteLine("Skriv in siffror för att välja ett alternativ:");

while (true)
{
    Console.WriteLine("1. Ungdom eller pensionär");
    Console.WriteLine("2. Alternativ 2");
    Console.WriteLine("3. Avsluta");

    string? input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("Ange din ålder:");

        // Allow null
        string? ageInput = Console.ReadLine();

        if (!string.IsNullOrEmpty(ageInput) && int.TryParse(ageInput, out int age))
        {
            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80 kr");
            }
            else if (age >= 64)
            {
                Console.WriteLine("Pensionärspris: 90 kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120 kr");
            }
        }
            
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