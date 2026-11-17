// Úloha 18: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Anna: 1
//   Boris: 3
//   Cyril: 2

Student[] students = new Student[3];
students[0] = new Student { Name = "Anna", Grade = 1 };
students[1] = new Student { Name = "Boris", Grade = 3 };
students[2] = new Student { Name = "Cyril", Grade = 2 };

for (int i = 0; i <= students.Length; i++)
{
    Console.WriteLine(students[i].Name + ": " + students[i].Grade);
}

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}
