// Úloha 14: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Can go out: False

// Von ideme, ak je slnečno ALEBO oblačno, a ZÁROVEŇ máme bundu.
bool isSunny = true;
bool isCloudy = false;
bool hasJacket = false;

bool canGoOut = isSunny || isCloudy && hasJacket;
Console.WriteLine("Can go out: " + canGoOut);
