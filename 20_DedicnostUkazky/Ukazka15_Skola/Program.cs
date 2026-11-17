// ===== DEDIČNOSŤ 15 – Škola (zhrnutie) =====
// Pojmy: base konštruktor, List<Person> s rôznymi odvodenými objektmi, List<Student> len študenti
// Skús zmeniť:
//   1. Pridaj ďalšieho študenta aj učiteľa.
//   2. Pridaj triedu Janitor : Person a zaraď ho medzi všetkých.
//   3. Vypíš priemerný vek všetkých osôb.

Student anna = new Student("Anna", 17, 1);
Student boris = new Student("Boris", 18, 2);
Teacher peter = new Teacher("Peter", 40, "Informatika");

List<Person> everyone = new List<Person>();
everyone.Add(anna);
everyone.Add(boris);
everyone.Add(peter);

List<Student> students = new List<Student>();
students.Add(anna);
students.Add(boris);

Console.WriteLine("Osob v skole: " + everyone.Count);
foreach (Person p in everyone)
{
    Console.WriteLine(p.Name + " (" + p.Age + ")");
}

int sumGrades = 0;
foreach (Student s in students)
{
    sumGrades = sumGrades + s.Grade;
}
Console.WriteLine("Priemer znamok: " + (double)sumGrades / students.Count);
Console.WriteLine(peter.Name + " uci " + peter.Subject);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Student : Person
{
    public int Grade { get; set; }

    public Student(string name, int age, int grade) : base(name, age)
    {
        Grade = grade;
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, int age, string subject) : base(name, age)
    {
        Subject = subject;
    }
}
