
Random random = new Random();

// Vygenerování náhodného čísla od 1 do 100
int hledaneCislo = random.Next(1, 101);

int tip = 0;
int pocetPokusu = 0;

Console.WriteLine("=== HADEJ CISLO ===");
Console.WriteLine("Myslim si cislo od 1 do 100.");
Console.WriteLine("Zkus ho uhodnout!");

while (tip != hledaneCislo)
{
    Console.Write("\nZadej svůj tip: ");
    tip = int.Parse(Console.ReadLine());

    pocetPokusu++;

    if (tip < hledaneCislo)
    {
        Console.WriteLine("Moje cislo je VYSSI!");
    }
    else if (tip > hledaneCislo)
    {
        Console.WriteLine("Moje cislo je NIZSI!");
    }
    else
    {
        Console.WriteLine("Spravne! Uhodl jsi cislo!");
        Console.WriteLine("Pocet pokusu: " + pocetPokusu);
    }
}
