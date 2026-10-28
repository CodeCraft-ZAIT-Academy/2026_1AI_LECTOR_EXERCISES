// ===== 10 – Dvojrozmerné polia (matica) =====
// Ukáž:       int[,] je tabuľka. Prvý index je riadok, druhý stĺpec: matrix[riadok, stĺpec].
//             Piškvorky: pole 3x3 znakov.
// Skús zmeniť: hodnoty matice; polož ďalšie X a O na plochu.

int[,] matrix = new int[2, 2];
matrix[0, 0] = 1;   // prvý riadok, prvý stĺpec
matrix[0, 1] = 2;   // prvý riadok, druhý stĺpec
matrix[1, 0] = 3;   // druhý riadok, prvý stĺpec
matrix[1, 1] = 4;   // druhý riadok, druhý stĺpec
Console.WriteLine("matrix[1, 0] = " + matrix[1, 0]);

// Inicializácia hneď: 2 riadky, 3 stĺpce
int[,] table = { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine("Riadky: " + table.GetLength(0) + ", stĺpce: " + table.GetLength(1));
Console.WriteLine("table[0, 2] = " + table[0, 2]);   // 3
Console.WriteLine("table[1, 1] = " + table[1, 1]);   // 5

// Piškvorky
char[,] board = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
board[0, 0] = 'X';
board[1, 1] = 'O';
board[2, 2] = 'X';
board[0, 2] = 'O';

Console.WriteLine();
Console.WriteLine(board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
Console.WriteLine("-+-+-");
Console.WriteLine(board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
Console.WriteLine("-+-+-");
Console.WriteLine(board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
