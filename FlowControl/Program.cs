// Definiera pris och åldersgränser som konstanter
const int UngdomsPris = 80;
const int PensionärsPris = 90;
const int StandardPris = 120;
const int UngdomsGräns = 20;
const int PensionärsGräns = 64;

bool fortsätt = true;

while (fortsätt)
{
// Visa huvudmenyn
    Console.WriteLine("Huvudmeny");
    Console.WriteLine("Skriv in siffror för att välja ett alternativ:");
    Console.WriteLine("1. Beräkna pris");
    Console.WriteLine("2. Upprepa text");
    Console.WriteLine("3. Visa tredje ordet");
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
    for (int i = 0; i < antalPersoner; i++)
    {
        Console.WriteLine($"Person {i + 1}: Hur gammal är du?");

        string? ageInput = Console.ReadLine();

        if (int.TryParse(ageInput, out int age))
        {
            price += GetPriceForAge(age);
        }
        else
        {
            Console.WriteLine("Ogiltig ålder, försök igen.");

            try
            {
                i--; // Minska i för att fråga om samma person igen
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ett fel inträffade: " + ex.Message);
            }
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
void HandleThirdWord()
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
    else
    {
        Console.WriteLine("Ingen mening angavs.");
    }
}
void HandleRepeatText()
{
    Console.WriteLine("Anger en godtycklig text:");
    string? text = Console.ReadLine();
    // Upprepa texten tio gånger
    for (int i = 0; i < 10; i++)
    {
        Console.Write(text + " " + (i + 1));
    }
    Console.WriteLine();
}

void HandleExit()
{
    Console.WriteLine("Avslutar programmet...");
    fortsätt = false;
}

static int GetPriceForAge(int age)
{
    if (age < 5 || age > 100) return 0;
    if (age < UngdomsGräns) return UngdomsPris;
    if (age > PensionärsGräns) return PensionärsPris;
    return StandardPris;
}
}