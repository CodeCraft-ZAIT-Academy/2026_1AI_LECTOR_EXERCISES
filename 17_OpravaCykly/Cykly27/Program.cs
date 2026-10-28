// Úloha 27: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Not Found

// Meno Bob v poli nie je, má sa vypísať Not Found.
string[] names = { "John", "Jane", "Alex" };
string search = "Bob";
bool found = true;
foreach (string name in names)
{
    if (name == search)
    {
        found = true;
        break;
    }
}
Console.WriteLine(found ? "Found" : "Not Found");
