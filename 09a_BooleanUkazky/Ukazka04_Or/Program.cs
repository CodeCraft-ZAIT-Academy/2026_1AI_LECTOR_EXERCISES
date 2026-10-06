// ===== 04 – Operátor OR (||) =====
// Ukáž:       || je pravda, keď je ASPOŇ JEDNA strana pravda ("alebo").
// Analógia:   Zoberieme si bundu, ak je zima ALEBO fúka vietor.
// Skús zmeniť: hodnoty isSunny a isWarm. Kedy je výsledok false?

bool isSunny = true;
bool isWarm = false;

bool isGoodWeather = isSunny || isWarm;   // príklad z lekcie
Console.WriteLine("isSunny || isWarm = " + isGoodWeather);

// Všetky štyri kombinácie
Console.WriteLine();
Console.WriteLine("true  || true  = " + (true || true));
Console.WriteLine("true  || false = " + (true || false));
Console.WriteLine("false || true  = " + (false || true));
Console.WriteLine("false || false = " + (false || false));
