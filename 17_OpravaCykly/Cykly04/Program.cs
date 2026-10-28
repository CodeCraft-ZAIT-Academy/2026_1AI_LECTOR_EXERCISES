// Úloha 4: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   John!
//   Jane!

string[] names = { "John", "Jane" };
foreach (string name in names)
{
    name = name + "!";
    Console.WriteLine(name);
}
