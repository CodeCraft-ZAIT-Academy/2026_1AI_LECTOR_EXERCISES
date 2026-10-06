// ===== 15 – Bonus: De Morganove zákony =====
// Ukáž:       !(a && b) je to isté ako !a || !b
//             !(a || b) je to isté ako !a && !b
//             Zákony si overíme tabuľkou všetkých kombinácií – v poslednom stĺpci musí byť vždy True.

Console.WriteLine("a     | b     | !(a&&b) | !a||!b | equal?   | !(a||b) | !a&&!b | equal?");
Check(true, true);
Check(true, false);
Check(false, true);
Check(false, false);

static void Check(bool a, bool b)
{
    bool left1 = !(a && b);
    bool right1 = !a || !b;
    bool left2 = !(a || b);
    bool right2 = !a && !b;

    Console.WriteLine(a.ToString().PadRight(5) + " | " + b.ToString().PadRight(5) + " | " +
                      left1.ToString().PadRight(7) + " | " + right1.ToString().PadRight(6) + " | " + (left1 == right1).ToString().PadRight(8) + " | " +
                      left2.ToString().PadRight(7) + " | " + right2.ToString().PadRight(6) + " | " + (left2 == right2));
}
