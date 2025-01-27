Teacher teacher1 = new Teacher();

StaticTeacher.ChangeMyName("My staic name");


Teacher refTeacher = teacher1;

refTeacher.ChangeMyName("Klime");

Console.WriteLine(teacher1.Name);

Teacher teacher2 = new Teacher("Klime", "CS");

string name, subject;
name = "Klime";
subject = "CS";
Teacher teacher21 = new Teacher(name, subject);

Console.WriteLine(teacher21.Name);

teacher21.ChangeMyName("Klime2");

Console.WriteLine(teacher21.Name);

Teacher teacher3 = new Teacher("Klime", "CS");

int resultat = teacher3.AddBestStudent(new Student("001", "KlimeStudent", new[] { 1, 2, 3 }, new DateOnly(1994, 8, 8)));

int[] ocenki = new[] { 1, 2, 3 };
DateOnly DatumNaRagjanje = new DateOnly(1994, 8, 8);
Student najdobarStudent = new Student("001", "KlimeStudent", ocenki, DatumNaRagjanje);
Teacher teacher31 = new Teacher("Klime", "CS");
teacher31.AddBestStudent(najdobarStudent);

Student TeachersBestStudent = teacher31.GetBestStudent();

Console.WriteLine(teacher31.GetBestStudent());

Console.WriteLine("Program finished");

public static class StaticTeacher
{
    public static string name = "";
    public static string subject = "";
    public static Student? bestStudent = null;


    public static void ChangeMyName(string newName)
    {
        name = newName;

    }

    public static int AddBestStudent(Student newBestStudent)
    {
        bestStudent = newBestStudent;

        return 1;
    }

    public static Student GetBestStudent()
    {
        return (Student)bestStudent;
    }
}

public class Teacher
{
    public string Name { get; private set; }
    public string Subject { get; set; }
    public Student BestStudent { get; set; }

    public Teacher() { }
    public Teacher(string name, string subject)
    {
        Name = name;
        Subject = subject;
    }

    public Teacher(string name, string subject, Student bestStudent)
    {
        Name = name;
        Subject = subject;
        BestStudent = bestStudent;
    }

    public void ChangeMyName(string newName)
    {
        Name = newName;

    }

    public int AddBestStudent(Student newBestStudent)
    {
        BestStudent = newBestStudent;

        return 1;
    }

    public Student GetBestStudent()
    {
        return BestStudent;
    }
}

public struct Student
{
    public string id;
    public string name;
    public int[] ocenki;
    public DateOnly dateofbirth;


    public Student(string id, string name, int[] ocenki, DateOnly dateofbirth)
    {
        this.id = id;
        this.name = name;
        this.ocenki = ocenki;
        this.dateofbirth = dateofbirth;
    }

    public void AddGrade(int ocenka)
    {
        int[] newOcenki = new int[ocenki.Length + 1];
        int pozicija = 0;

        foreach (int staraOcenkaVoStarataNiza in ocenki)
        {
            newOcenki[pozicija++] = staraOcenkaVoStarataNiza;
        }

        newOcenki[pozicija] = ocenka;

        ocenki = newOcenki;

    }
    public override string ToString()
    {
        return $"Name: {name}, ocenki: {ocenki}, dateofbirth: {dateofbirth}";
    }
}
