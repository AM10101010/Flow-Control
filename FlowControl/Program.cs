// Konstanter för priser och åldersgränser
const int UngdomsPris = 80;
const int PensionärsPris = 90;
const int StandardPris = 120;
const int UngdomsGräns = 20;
const int PensionärsGräns = 64;

bool fortsätt = true;

// Huvudloop som körs tills användaren väljer att avsluta
while (fortsätt)
{
    // Visa huvudmenyn
    Console.WriteLine("Huvudmeny");
    Console.WriteLine("---------");
    Console.WriteLine("Skriv in siffror för att välja ett alternativ:");
    Console.WriteLine();
    Console.WriteLine("1. Beräkna pris");
    Console.WriteLine("2. Upprepa tio gånger");
    Console.WriteLine("3. Det tredje ordet");
    Console.WriteLine("4. Avsluta");
    Console.WriteLine();

    string? input = Console.ReadLine();

    switch (input)
    {
        case "1": HandlePriceCalculation(); break;
        case "2": HandleRepeatText(); break;
        case "3": HandleThirdWord(); break;
        case "4": HandleExit(); break;
        default: Console.WriteLine("Ogiltigt val, försök igen."); break;
    }
}

// Metod för att hantera inmatning av text och upprepa den tio gånger1
void HandleRepeatText()
{
    Console.WriteLine("Anger en godtycklig text:");
    string? text = Console.ReadLine();
    // Upprepa texten tio gånger
    for (int i = 0; i < 10; i++)
    {
        Console.Write(text + (i + 1) + ", ");
    }
    Console.WriteLine();
}
// Hantera avslutning av programmet
void HandleExit()
{
    Console.WriteLine("Avslutar programmet...");
    fortsätt = false;
}

// Beräkna pris baserat på antal personer och deras ålder
void HandlePriceCalculation()
{
    int price = 0;
    // Fråga hur många personer det gäller
    Console.WriteLine("Hur många personer?");
    string? personerInput = Console.ReadLine();

    // Validera input — måste vara ett heltal större än 0
    if (!int.TryParse(personerInput, out int antalPersoner) || antalPersoner < 1)
    {
        Console.WriteLine("Ogiltigt antal, försök igen.");
        return;
    }
    // Loopa igenom varje person och fråga efter ålder
    int i = 0;
    while (i < antalPersoner)
    {
        Console.Write($"Ange ålder för person {i + 1}: ");
        string? ageInput = Console.ReadLine();

        if (int.TryParse(ageInput, out int age))
        {
            int personPris = GetPriceForAge(age);
            string kategori = GetCategoryForAge(age);
            Console.WriteLine($"Person {i + 1} är {kategori}. Pris: {personPris} kr");
            price += personPris;
            i++;
        }
        else
        {
            Console.WriteLine("Ogiltig ålder, försök igen.");
        }
    }
    // Skriv ut totalsumman för alla personer
    Console.WriteLine();
    Console.WriteLine("******************************************");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("             Totalt pris: " + price + " kr");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("******************************************");
    Console.WriteLine();
}

// Metod för att hantera inmatning av en mening och visa det tredje ordet
void HandleThirdWord()
{
    Console.WriteLine("Skriv in en mening:");
    string? line = Console.ReadLine();

    // Kontrollera om input är null
    if (line != null)
    {
        var split = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
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
    else
    {
        Console.WriteLine("Ingen mening angavs.");
    }
}

// Metod för att beräkna pris baserat på ålder
int GetPriceForAge(int age)
{
    if (age < 5 || age > 100) return 0;
    if (age < UngdomsGräns) return UngdomsPris;
    if (age > PensionärsGräns) return PensionärsPris;
    return StandardPris;
}

string GetCategoryForAge(int age)
{
    if (age < 5 || age > 100) return "";
    if (age < UngdomsGräns) return "ungdom";
    if (age > PensionärsGräns) return "pensionär";
    return "vuxen";
}
