// ===== 05 – Hľadanie v poli: foreach a break =====
// Ukáž:       príznak (found = false), ktorý sa v cykle nastaví na true. break ukončí cyklus hneď po nájdení.
//             Príklad z lekcie, doplnený o hľadanie indexu.
// Skús zmeniť: hľadané meno (search) na "Alex", "Bob". Čo sa vypíše?

string[] names = { "John", "Jane", "Alex" };
string search = "Jane";
bool found = false;

foreach (string name in names)
{
    if (name == search)
    {
        found = true;
        break;
    }
}

Console.WriteLine(found ? "Found" : "Not Found");

// Hľadanie indexu: potrebujeme for
int foundIndex = -1;
for (int i = 0; i < names.Length; i++)
{
    if (names[i] == search)
    {
        foundIndex = i;
        break;
    }
}
Console.WriteLine("Index: " + foundIndex);     // -1 znamená "nenájdené"
