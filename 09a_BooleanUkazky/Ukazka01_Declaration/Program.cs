// ===== 01 – Deklarácia a inicializácia bool =====
// Ukáž:       bool má len dve hodnoty: true a false.
//             V kóde sa píšu malými písmenami, vo výpise na konzole začínajú veľkým (True / False).
// Skús zmeniť: hodnoty premenných, pridaj vlastné (isWeekend, hasHomework).

bool isSunny = true;
bool isRaining = false;

Console.WriteLine("isSunny:   " + isSunny);
Console.WriteLine("isRaining: " + isRaining);

// Hodnotu môžeme vypísať aj priamo
Console.WriteLine(true);
Console.WriteLine(false);

// Hodnotu premennej môžeme prepísať
isRaining = true;
Console.WriteLine("isRaining po zmene: " + isRaining);

// Názvy bool premenných sa zvyčajne píšu ako otázka/tvrdenie: isSunny, hasKey, canEnter
// Zlé názvy: sunny, flag, x
