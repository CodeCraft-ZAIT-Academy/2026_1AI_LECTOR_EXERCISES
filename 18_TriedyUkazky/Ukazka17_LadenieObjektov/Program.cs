// ===== TRIEDY 17 – Ladenie objektov =====
// Pojmy: Locals a Watch pri objektoch, F11 (Step Into) do metódy objektu
// Postup: dvojklik vľavo pri čísle riadku (breakpoint) pri každom // STOP, spusti F5, krokuj F10.
// Úlohy:
//   STOP 1: Rozbaľ premennú students v okne Locals. Aká je Grade Borisa?
//   STOP 2: Si v metóde Improve(). Čo vidíš v okne Locals? Ktorý objekt je „this“?
//   STOP 3: Aká je hodnota sum po cykle? Pridaj do Watch výraz students[1].Grade.

List<Student> students = new List<Student>();
students.Add(new Student { Name = "Anna", Grade = 1 });
students.Add(new Student { Name = "Boris", Grade = 3 });
students.Add(new Student { Name = "Cyril", Grade = 2 });

Console.WriteLine("Pred zlepsenim: " + students[1].Describe());    // STOP 1
students[1].Improve();                                              // STOP 2 (F11 = vstúp dnu)
Console.WriteLine("Po zlepseni: " + students[1].Describe());

int sum = 0;
foreach (Student s in students)
{
    sum = sum + s.Grade;
}
Console.WriteLine("Sucet znamok: " + sum);                          // STOP 3

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public void Improve()
    {
        if (Grade > 1)
        {
            Grade = Grade - 1;
        }
    }

    public string Describe()
    {
        return Name + ": " + Grade;
    }
}
