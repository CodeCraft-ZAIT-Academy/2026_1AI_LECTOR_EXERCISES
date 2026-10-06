// ===== 11 – Krokovanie booleovských výrazov v debuggeri =====
// Ukáž:       breakpoint (F9) na prvý riadok, spusti F5 a krokuj F10.
//             V okne Locals sleduj, ako sa hodnoty bool postupne dopĺňajú.
//             Pred každým krokom nechaj žiakov tipovať, aká bude hodnota.
// Tip:        v okne Watch zadaj výraz, napr. isSunny && !isRaining, a pozri výsledok.

bool isSunny = true;
bool isRaining = false;
int temperature = 22;

bool isWarm = temperature >= 20;
bool isGoodWeather = isSunny && isWarm;
bool needUmbrella = isRaining || !isSunny;
bool goOutside = isGoodWeather && !needUmbrella;

Console.WriteLine("isWarm:        " + isWarm);
Console.WriteLine("isGoodWeather: " + isGoodWeather);
Console.WriteLine("needUmbrella:  " + needUmbrella);
Console.WriteLine("goOutside:     " + goOutside);
