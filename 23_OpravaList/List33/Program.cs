// Úloha 33: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Obsluzeny: Anna
//   Obsluzeny: Boris
//   Obsluzeny: Cyril

List<string> queue = new List<string> { "Anna", "Boris", "Cyril" };

for (int i = 0; i < 3; i++)
{
    string served = queue[0];
    Console.WriteLine("Obsluzeny: " + served);
}
