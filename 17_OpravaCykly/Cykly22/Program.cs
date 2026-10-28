// Úloha 22: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Average: 2.8

// Priemer známok 1, 2, 2, 4, 5 má byť 2,8.
int[] grades = { 1, 2, 2, 4, 5 };
int sum = 0;
foreach (int grade in grades)
{
    sum += grade;
}
double average = sum / grades.Length;
Console.WriteLine("Average: " + average);
