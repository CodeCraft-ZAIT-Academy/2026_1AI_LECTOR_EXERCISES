// ===== 02 – Index: prvý prvok má index 0 =====
// Ukáž:       k prvku pristupujeme cez index v hranatých zátvorkách. Prvý prvok má index 0!
//
//               index:    0    1    2    3    4
//               hodnota:  10   20   30   0    0
//
// Skús zmeniť: priraď hodnotu aj do numbers[3] a numbers[4]. Vypíš numbers[1] a numbers[3].

int[] numbers = new int[5];
numbers[0] = 10;   // prvý prvok
numbers[1] = 20;   // druhý prvok
numbers[2] = 30;   // tretí prvok

Console.WriteLine("Celé pole: " + string.Join(", ", numbers));
Console.WriteLine("numbers[0] = " + numbers[0]);
Console.WriteLine("numbers[1] = " + numbers[1]);
Console.WriteLine("numbers[2] = " + numbers[2]);
Console.WriteLine("numbers[3] = " + numbers[3] + "   (nikdy sme mu nič nepriradili)");
Console.WriteLine("numbers[4] = " + numbers[4]);
