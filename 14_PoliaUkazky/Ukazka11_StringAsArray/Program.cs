// ===== 11 – Reťazec ako pole znakov =====
// Ukáž:       k znakom reťazca pristupujeme cez index. Platí rovnaké pravidlo: prvý znak má index 0.
//             Reťazec sa po znakoch meniť NEDÁ, ale pole znakov (char[]) áno.
// Skús zmeniť: text v message; odkomentuj riadok message[0] = 'J'; – aká je chyba?

string message = "Hello, World!";   // príklad z lekcie
Console.WriteLine(message[0]);                     // H
Console.WriteLine(message[12]);                    // !
Console.WriteLine("Length: " + message.Length);
Console.WriteLine("Posledný znak: " + message[message.Length - 1]);

// message[0] = 'J';    // chyba pri kompilácii: reťazec sa nedá meniť po znakoch

char[] chars = message.ToCharArray();   // reťazec -> pole znakov
chars[0] = 'J';
string changed = new string(chars);     // pole znakov -> reťazec
Console.WriteLine(changed);             // Jello, World!
