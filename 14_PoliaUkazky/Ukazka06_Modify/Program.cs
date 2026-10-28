// ===== 06 – Zmena prvkov poľa a výmena =====
// Ukáž:       prvok poľa sa správa ako obyčajná premenná: môžeme ho čítať aj prepisovať a počítať s ním.
//             Výmena dvoch prvkov potrebuje pomocnú premennú (rovnako ako pri dvoch premenných).
// Skús zmeniť: vymeň prvky 0 a 2 namiesto 0 a 1.

int[] numbers = { 10, 20, 30 };
numbers[1] = 25;                                   // príklad z lekcie
Console.WriteLine("Po zmene: " + string.Join(", ", numbers));

numbers[2] = numbers[2] * 2;                       // počítanie s prvkom
Console.WriteLine("Po zdvojnásobení: " + string.Join(", ", numbers));

int sumFirstTwo = numbers[0] + numbers[1];
Console.WriteLine("Súčet prvých dvoch: " + sumFirstTwo);

// Výmena prvkov 0 a 1
int temp = numbers[0];
numbers[0] = numbers[1];
numbers[1] = temp;
Console.WriteLine("Po výmene: " + string.Join(", ", numbers));
