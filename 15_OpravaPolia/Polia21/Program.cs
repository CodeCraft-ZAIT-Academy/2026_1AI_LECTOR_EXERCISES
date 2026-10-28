// Úloha 21: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   original: 1, 2, 3
//   copy:     99, 2, 3

// Zmena v kópii nesmie zmeniť pôvodné pole.
int[] original = { 1, 2, 3 };
int[] copy = original;
copy[0] = 99;
Console.WriteLine("original: " + string.Join(", ", original));
Console.WriteLine("copy:     " + string.Join(", ", copy));
