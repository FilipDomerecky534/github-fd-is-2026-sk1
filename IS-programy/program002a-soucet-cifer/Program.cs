// POMOCI MATEMATICKYCH OPERACI


// Řídicí proměnná pro opakování programu
string again = "a";

// Hlavní smyčka programu
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("******** Součet a součin cifer ****");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    // 1. Načtení celého čísla
    Console.Write("Zadejte celé číslo: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
    }

    // 2. Pomocné proměnné
    int numberBackup = number;
    int sum = 0;
    long product = 1;
    int digit;

    // 3. Ošetření záporných čísel
    // Použití long umožní bezpečně zpracovat i int.MinValue
    long tempNumber = number;

    if (tempNumber < 0)
    {
        tempNumber = -tempNumber;
    }

    // 4. Zvláštní případ pro nulu
    if (tempNumber == 0)
    {
        sum = 0;
        product = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Rozklad čísla na cifry:");

        // 5. Matematický rozklad čísla na cifry
        while (tempNumber > 0)
        {
            digit = (int)(tempNumber % 10);

            sum = sum + digit;
            product = product * digit;

            Console.WriteLine($"Získána cifra: {digit}");

            tempNumber = tempNumber / 10;
        }
    }

    // 6. Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo:  {numberBackup}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine($"Ciferný součin: {product}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    // 7. Dotaz na opakování programu
    Console.Write("Pro opakování programu stiskněte 'a': ");
    again = Console.ReadLine() ?? "";
}
