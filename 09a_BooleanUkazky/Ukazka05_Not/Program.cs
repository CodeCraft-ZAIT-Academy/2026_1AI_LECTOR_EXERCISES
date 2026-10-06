// ===== 05 – Operátor NOT (!) =====
// Ukáž:       ! obráti hodnotu: true sa zmení na false a naopak.
// Skús zmeniť: hodnotu isCold; použi dvojitú negáciu !!isCold – čo vyjde?

bool isCold = false;
bool isNotCold = !isCold;   // príklad z lekcie

Console.WriteLine("isCold    = " + isCold);
Console.WriteLine("isNotCold = " + isNotCold);

Console.WriteLine();
Console.WriteLine("!true  = " + !true);
Console.WriteLine("!false = " + !false);
Console.WriteLine("!!true = " + !!true);   // dvojitá negácia vráti pôvodnú hodnotu

// Negáciu môžeme použiť aj na porovnanie
int age = 20;
bool isAdult = age >= 18;
bool isNotAdult = !isAdult;
Console.WriteLine("isAdult = " + isAdult + ", isNotAdult = " + isNotAdult);
