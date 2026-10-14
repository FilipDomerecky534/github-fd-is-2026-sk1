Console.WriteLine("Zadejte prvni hodnotu");
int first = int.Parse(Console.ReadLine()); //ulozi do promene vstup od uzivatele potom co ho prevede na int pomoci parse
Console.WriteLine("Zadejte posledni hodnotu");
int last = int.Parse(Console.ReadLine());
Console.WriteLine("Zadejte krok mezi hodnotami");
int step = int.Parse(Console.ReadLine());

for (int i = first; i <= last; i += step)
{
    Console.WriteLine(i);
}