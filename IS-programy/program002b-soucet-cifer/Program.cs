//POMOCI CYKLU DO-WHILE



string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();

    Console.WriteLine("***********************************");
    Console.WriteLine("******** Součet a součin cifer ****");
    Console.WriteLine("***********************************");
    Console.WriteLine();

    // Načtení čísla
    Console.Write("Zadejte celé číslo: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Zadejte platné celé číslo: ");
    }

    // Uložení původního čísla
    int original = number;

    // Převod na kladnou hodnotu
    long n = Math.Abs((long)number);

    // Inicializace výsledků
    int sum = 0;
    long product = 1;

    Console.WriteLine();
    Console.WriteLine("Rozklad čísla na cifry:");

    // Postupné získávání jednotlivých cifer
    do
    {
        int digit = (int)(n % 10);

        Console.WriteLine("Cifra: " + digit);

        sum += digit;
        product *= digit;

        n /= 10;

    } while (n > 0);

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("===================================");
    Console.WriteLine("Původní číslo: " + original);
    Console.WriteLine("Ciferný součet: " + sum);
    Console.WriteLine("Ciferný součin: " + product);
    Console.WriteLine("===================================");

    Console.WriteLine();
    Console.Write("Chcete pokračovat? (a/n): ");
    again = Console.ReadLine() ?? "";
}
