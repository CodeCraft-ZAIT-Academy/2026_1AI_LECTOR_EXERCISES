// ===== TRIEDY 07 – Pole objektov =====
// Pojmy: Student[], prvky poľa sú najprv null, new pre každý prvok, for / foreach
// Skús zmeniť:
//   1. Zakomentuj riadok students[1] = new Student ... a pozri sa, čo sa stane (NullReferenceException).
//   2. Pridaj štvrtého študenta (zväčši pole).
//   3. Vypíš len študentov so známkou 1 alebo 2.

Student[] students = new Student[3];

students[0] = new Student { Name = "Anna", Grade = 1 };
students[1] = new Student { Name = "Boris", Grade = 3 };
students[2] = new Student { Name = "Cyril", Grade = 2 };

foreach (Student s in students)
{
    Console.WriteLine(s.Name + ": " + s.Grade);
}

double sum = 0;
for (int i = 0; i < students.Length; i++)
{
    sum = sum + students[i].Grade;
}
Console.WriteLine("Priemer: " + sum / students.Length);

Student best = students[0];
foreach (Student s in students)
{
    if (s.Grade < best.Grade)
    {
        best = s;
    }
}
Console.WriteLine("Najlepsi: " + best.Name);

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}
