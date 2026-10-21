Console.WriteLine("**************************************");
Console.WriteLine("************* Vypis rady *************");
Console.WriteLine("**************************************");

Console.WriteLine("Zadejte prvni hodnotu");
int first;
while (!int.TryParse(Console.ReadLine(), out first))
{
    Console.Write("Zadali jste neplatné číslo. Zadejte číslo znovu: ");
}
Console.WriteLine("Zadejte posledni hodnotu");
int last;
while (!int.TryParse(Console.ReadLine(), out last))
{
    Console.Write("Zadali jste neplatné číslo. Zadejte číslo znovu: ");
}
Console.WriteLine("Zadejte krok mezi hodnotami");
int step;
while (!int.TryParse(Console.ReadLine(), out step) || step < 0)
{
    Console.Write("Zadali jste neplatné číslo. Zadejte číslo znovu: ");
}
Console.WriteLine("---------------");

for (int i = first; i <= last; i += step)
{
    Console.WriteLine(i);
}