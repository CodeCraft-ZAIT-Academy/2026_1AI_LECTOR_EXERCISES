// Úloha 21: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Obsluzeny: Anna
//   Obsluzeny: Boris

List<string> queue = new List<string> { "Anna", "Boris" };

for (int i = 0; i < 3; i++)
{
    string served = queue[0];
    queue.RemoveAt(0);
    Console.WriteLine("Obsluzeny: " + served);
}
