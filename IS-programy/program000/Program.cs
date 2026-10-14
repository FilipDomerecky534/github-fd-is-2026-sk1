string again = "a";


while(again.ToLower() == "a")
{
    Console.WriteLine();
    Console.Write("Pro opakování programu stisknete klavesu a. Následně potvrďte klavesou Enter");
    again = Console.ReadLine() ?? "";
}
