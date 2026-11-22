Console.Write("Zadej počet čísel: ");
int pocet = int.Parse(Console.ReadLine());

Console.Write("Zadej dolní mez: ");
int dolniMez = int.Parse(Console.ReadLine());

Console.Write("Zadej horní mez: ");
int horniMez = int.Parse(Console.ReadLine());

// Vytvoření pole
int[] cisla = new int[pocet];

// Generátor náhodných čísel
Random random = new Random();

// Počítadla
int kladna = 0;
int zaporna = 0;
int nulova = 0;
int suda = 0;
int licha = 0;

// Generování čísel
for (int i = 0; i < pocet; i++)
{
    cisla[i] = random.Next(dolniMez, horniMez + 1);
}

// Výpis čísel a jejich vyhodnocení
Console.WriteLine("\nVygenerovana cisla:");

for (int i = 0; i < pocet; i++)
{
    int cislo = cisla[i];

    Console.Write(cislo + " ");

    // Kladná, záporná a nulová čísla
    if (cislo > 0)
        kladna++;
    else if (cislo < 0)
        zaporna++;
    else
        nulova++;

    // Sudá a lichá čísla
    if (cislo % 2 == 0)
        suda++;
    else
        licha++;
}

// Výsledky
Console.WriteLine("\n\nVyhodnoceni:");

Console.WriteLine("Kladna cisla: " + kladna);
Console.WriteLine("Zaporna cisla: " + zaporna);
Console.WriteLine("Nulova cisla: " + nulova);

Console.WriteLine("Suda cisla: " + suda);
Console.WriteLine("Licha cisla: " + licha);
