// Úloha 15: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Stay home: True

// Ostaneme doma, ak NEPLATÍ, že je slnečno a zároveň teplo.
bool isSunny = true;
bool isWarm = false;

bool stayHome = !isSunny && !isWarm;
Console.WriteLine("Stay home: " + stayHome);
