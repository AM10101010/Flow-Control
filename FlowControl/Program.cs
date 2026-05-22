Console.WriteLine("Huvudmeny");
Console.WriteLine("Skriv in siffror för att välja ett alternativ:");
Console.WriteLine();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Antalet personer och deras ålder");
    Console.WriteLine("2. Alternativ 2");
    Console.WriteLine("3. Avsluta");

    string? input = Console.ReadLine();
    double price = 0;
    if (input == "1")
    {
        Console.WriteLine("Hur många personer?");
        string? personerInput = Console.ReadLine();

        if (!int.TryParse(personerInput, out int antalPersoner) || antalPersoner < 1)
        {
          Console.WriteLine("Ogiltigt antal, försök igen.");
          continue;
        }
        
        for (int i = 0; i < int.Parse(personerInput ?? "0"); i++)
        {
            Console.WriteLine($"Person {i + 1}: Hur gammal är du?");
            string? ageInput = Console.ReadLine();
            int age = int.Parse(ageInput ?? "0");
         
            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80 kr");
                price  += 80;
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90 kr");
                price += 90;
            }
            else
            {
                Console.WriteLine("Standardpris: 120 kr");
                price += 120;
            }
         }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Totalt pris: " + price + " kr");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
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