// Úloha 29: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Anna je v zozname

List<string> names = new List<string> { "Anna", "Boris", "Cyril" };
if (names.IndexOf("Anna") > 0)
{
    Console.WriteLine("Anna je v zozname");
}
else
{
    Console.WriteLine("Anna v zozname nie je");
}
