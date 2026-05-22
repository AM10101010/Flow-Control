
// Visa huvudmenyn

Console.WriteLine("Huvudmeny");
Console.WriteLine("Skriv in siffror för att välja ett alternativ:");
Console.WriteLine();

while (true)
{
    // Visa huvudmenyn med fyra alternativ:
    // 1. Räkna ut totalpris baserat på antal personer och deras åldrar
    // 2. Skriv ut en text tio gånger
    // 3. Hämta och visa det tredje ordet från en mening
    // 4. Avsluta programmet

    Console.WriteLine();
    Console.WriteLine("1. Antalet personer och deras ålder");
    Console.WriteLine("2. Upprepa tio gånger");
    Console.WriteLine("3. Det tredje ordet");
    Console.WriteLine("4. Avsluta");

    string? input = Console.ReadLine();
    if (input == "1")
    {
        int price = 0;
        // Fråga hur många personer det gäller
        Console.WriteLine("Hur många personer?");
        string? personerInput = Console.ReadLine();

        // Validera input — måste vara ett heltal större än 0
        if (!int.TryParse(personerInput, out int antalPersoner) || antalPersoner < 1)
        {
          Console.WriteLine("Ogiltigt antal, försök igen.");
          continue;
        }

        // Loopa igenom varje person och fråga efter ålder
        for (int i = 0; i < antalPersoner; i++)
        {
            Console.WriteLine($"Person {i + 1}: Hur gammal är du?");
            string? ageInput = Console.ReadLine();
            int age = int.Parse(ageInput ?? "0");

            // Bestäm pris baserat på ålderskategori
            if (age > 100 || age < 5) 
            {
                Console.WriteLine("Barn under fem och pensionärer över 100 går gratis");
                price += 0;
                continue;
            }
            else if (age < 20)
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
            // Skriv ut totalsumman för alla personer
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Totalt pris: " + price + " kr");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
    }

    // Alternativ 2: Skriv ut en användarangiven text tio gånger
    else if (input == "2")
    {
        Console.WriteLine("Anger en godtycklig text:");
        string ? text = Console.ReadLine();
        // Upprepa texten tio gånger
        for (int i = 0; i < 10; i++)
        {
            Console.Write(text + " " + (i + 1));
        }
    }
    // Alternativ 3: Hämta och visa det tredje ordet från en mening
    else if (input == "3")
    {
       Console.WriteLine("Skriv in en mening:");
       string? line = Console.ReadLine();
       
       // Kontrollera om input är null
       if (line != null)
       {
         string[] split = line.Split(' ');
         int wordCount = split.Length;
         if (wordCount >= 3)
         {
              // Skriv ut det tredje ordet (index 2 eftersom arrayer börjar på 0)
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