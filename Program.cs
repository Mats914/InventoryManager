using System;

class Program
{
    static void Main()
    {
        // Skapar en strängvektor (array) med 5 platser
        string[] ryggsäck = new string[5];

        // Variabel för att hålla menyn igång
        bool körProgram = true;

        // Menyloop
        while (körProgram)
        {
            Console.Clear();
            Console.WriteLine("=== Ryggsäcksprogram ===");
            Console.WriteLine("1. Lägg till föremål");
            Console.WriteLine("2. Visa innehåll");
            Console.WriteLine("3. Sök föremål");
            Console.WriteLine("4. Avsluta");
            Console.Write("Välj ett alternativ: ");
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    // Användaren matar in fem föremål
                    for (int i = 0; i < ryggsäck.Length; i++)
                    {
                        Console.Write($"Ange föremål {i + 1}: ");
                        ryggsäck[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Föremålen är tillagda! Tryck på valfri tangent...");
                    Console.ReadKey();
                    break;

                case "2":
                    // Skriver ut alla föremål i ryggsäcken
                    Console.WriteLine("\nInnehåll i ryggsäcken:");
                    for (int i = 0; i < ryggsäck.Length; i++)
                    {
                        Console.WriteLine($"- {ryggsäck[i]}");
                    }
                    Console.WriteLine("\nTryck på valfri tangent...");
                    Console.ReadKey();
                    break;

                case "3":
                    // Söker efter ett föremål i ryggsäcken
                    Console.Write("\nVad vill du söka efter? ");
                    string sökord = Console.ReadLine();
                    bool hittad = false;

                    for (int i = 0; i < ryggsäck.Length; i++)
                    {
                        if (ryggsäck[i] == sökord)
                        {
                            Console.WriteLine($"\"{sökord}\" finns på plats {i + 1}.");
                            hittad = true;
                            break;
                        }
                    }

                    if (!hittad)
                    {
                        Console.WriteLine($"\"{sökord}\" hittades inte i ryggsäcken.");
                    }

                    Console.WriteLine("Tryck på valfri tangent...");
                    Console.ReadKey();
                    break;

                case "4":
                    // Avslutar programmet
                    körProgram = false;
                    Console.WriteLine("Programmet avslutas...");
                    break;

                default:
                    // Felhantering vid ogiltig inmatning
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
