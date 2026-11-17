// ===== LIST 05 – Pole vs. List =====
// Pojmy: pevná veľkosť vs. dynamická veľkosť, Length vs. Count, ToArray
// Skús zmeniť:
//   1. Zmeň počet opakovaní cyklu z 5 na 8. Zmenila sa veľkosť poľa? A listu?
//   2. Skús do poľa pridať šiesty prvok. Čo sa stane?
//   3. Prepíš ukážku s poľom tak, aby používala List.

int[] array = new int[3];              // vždy presne 3 miesta
array[0] = 1;
array[1] = 4;
array[2] = 9;
Console.WriteLine("Pole: Length = " + array.Length);

List<int> list = new List<int>();      // začína prázdny a rastie
for (int i = 1; i <= 5; i++)
{
    list.Add(i * i);
}
Console.WriteLine("List: Count = " + list.Count);
Console.WriteLine("Prvky: " + string.Join(", ", list));

int[] fromList = list.ToArray();       // list → pole
Console.WriteLine("Pole z listu: Length = " + fromList.Length);
