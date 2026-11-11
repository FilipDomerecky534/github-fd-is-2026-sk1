
string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************");
    Console.WriteLine("**** Vykreslení trojúhelníku ****");
    Console.WriteLine("*********************************");
    Console.WriteLine();

    // 1. Načtení šířky
    Console.Write("Zadejte šířku obrazce (přirozené číslo): ");
    int width;

    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Šířka musí být kladné číslo. Zadejte znovu: ");
    }

    // 2. Načtení výšky
    Console.Write("Zadejte výšku obrazce (přirozené číslo): ");
    int height;

    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Výška musí být kladné číslo. Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji trojúhelník o rozměrech {width} × {height}:");
    Console.WriteLine();

    // 3. Vykreslení trojúhelníku
    for (int i = 1; i <= height; i++)
    {
        int stars = i * width / height;

        for (int j = 1; j <= stars; j++)
        {
            Console.Write("* ");
        }

        Console.WriteLine();
    }

    // 4. Opakování programu
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
}
