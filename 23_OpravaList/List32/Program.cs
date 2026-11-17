// Úloha 32: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Obsluzeny: Anna
//   Zostava: Boris, Cyril

List<string> queue = new List<string> { "Anna", "Boris", "Cyril" };

string served = queue[queue.Count - 1];
queue.RemoveAt(queue.Count - 1);
Console.WriteLine("Obsluzeny: " + served);
Console.WriteLine("Zostava: " + string.Join(", ", queue));
