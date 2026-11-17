// ===== LIST 15 – Fronta (FIFO) =====
// Pojmy: FIFO (first in, first out), Add = pridaj na koniec, [0] + RemoveAt(0) = odober zo začiatku
// Skús zmeniť:
//   1. Pridaj do fronty ďalšieho zákazníka a predpovedz poradie obsluhy.
//   2. Čo sa stane, ak sa pokúsime obslúžiť zákazníka z prázdnej fronty? (Odkomentuj posledný riadok.)
//   3. Vypíš počet čakajúcich po každom obslúžení.

List<string> queue = new List<string>();

// Enqueue: pridaj na koniec
queue.Add("Anna");
queue.Add("Boris");
queue.Add("Cyril");
Console.WriteLine("Vo fronte: " + string.Join(", ", queue));

// Dequeue: prečítaj prvého a odstráň ho
string served = queue[0];
queue.RemoveAt(0);
Console.WriteLine("Obsluzeny: " + served + ", zostava: " + string.Join(", ", queue));

queue.Add("Dana");

while (queue.Count > 0)
{
    string next = queue[0];
    queue.RemoveAt(0);
    Console.WriteLine("Obsluzeny: " + next);
}

Console.WriteLine("Fronta je prazdna, pocet: " + queue.Count);
// string error = queue[0];      // ArgumentOutOfRangeException: fronta je prázdna
