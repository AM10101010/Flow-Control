Console.WriteLine("Huvudmeny");
Console.WriteLine("Skriv in siffror för att välja ett alternativ:");
Console.WriteLine();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Antalet personer och deras ålder");
    Console.WriteLine("2. Upprepa tio gånger");
    Console.WriteLine("3. Det tredje ordet");
    Console.WriteLine("4. Avsluta");

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
        Console.WriteLine("Anger en godtycklig text:");
        string ? text = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            Console.Write(text + " " + (i + 1));
        }
    }
    else if (input == "3")
    {
       Console.WriteLine("Skriv in en mening:");
       string? line = Console.ReadLine();
       
       if (line != null)
       {
         string[] split = line.Split(' ');
         if (split.Length >= 3)
         {
              Console.WriteLine();
              Console.WriteLine("Det tredje ordet är: " + split[2]);
              Console.WriteLine();
         }
         else
         {
              Console.WriteLine("Mening måste innehålla minst tre ord.");
         }
       }
    }
    else if (input == "4")
    {
        Console.WriteLine("Avslutar programmet...");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt val, försök igen.");
    }
}