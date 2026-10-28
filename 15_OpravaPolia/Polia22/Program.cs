// Úloha 22: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   3
//   4
//   8

// GetCell(matrix, riadok, stĺpec) vráti hodnotu z daného riadku a stĺpca.
int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
Console.WriteLine(GetCell(matrix, 0, 2));
Console.WriteLine(GetCell(matrix, 1, 0));
Console.WriteLine(GetCell(matrix, 2, 1));

static int GetCell(int[,] matrix, int row, int column)
{
    return matrix[column, row];
}
