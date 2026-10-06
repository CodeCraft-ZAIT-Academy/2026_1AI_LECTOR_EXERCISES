// ===== 03 – Operátor AND (&&) =====
// Ukáž:       && je pravda len vtedy, keď sú OBE strany pravda ("a zároveň").
// Analógia:   Pôjdeme na pláž, keď svieti slnko A ZÁROVEŇ je teplo.
// Skús zmeniť: hodnoty isSunny a isWarm – nájdi všetky kombinácie, kedy je výsledok true.

bool isSunny = true;
bool isWarm = false;

bool isGoodWeather = isSunny && isWarm;   // príklad z lekcie
Console.WriteLine("isSunny && isWarm = " + isGoodWeather);

// Všetky štyri kombinácie
Console.WriteLine();
Console.WriteLine("true  && true  = " + (true && true));
Console.WriteLine("true  && false = " + (true && false));
Console.WriteLine("false && true  = " + (false && true));
Console.WriteLine("false && false = " + (false && false));
