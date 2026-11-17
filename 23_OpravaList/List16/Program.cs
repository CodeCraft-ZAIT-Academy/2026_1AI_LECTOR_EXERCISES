// Úloha 16: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Anna
//   Boris
//   Cyril

List<string> names = new List<string> { "Anna", "Boris", "Cyril" };
for (int i = 0; i <= names.Count; i++)
{
    Console.WriteLine(names[i]);
}
