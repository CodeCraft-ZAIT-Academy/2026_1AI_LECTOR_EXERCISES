// ===== 01 – Cyklus while =====
// Ukáž:       blok { } sa opakuje, KÝM je podmienka pravdivá. Podmienka sa kontroluje pred každým prechodom.
//             Treba tri veci: 1) začiatočnú hodnotu (int i = 0),
//                             2) podmienku (i < 5),
//                             3) zmenu premennej v cykle (i++) – inak sa cyklus nikdy neskončí!
//
//             Sledovacia tabuľka:   prechod   i (na začiatku)   i < 5?   vypíše
//                                   1.        0                 áno      0
//                                   2.        1                 áno      1
//                                   ...
//                                   6.        5                 nie      cyklus končí
// Skús zmeniť: podmienku na i <= 5, začiatok na 3, i++ na i += 2.

int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("Cyklus skončil, i = " + i);
