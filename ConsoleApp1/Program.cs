public class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("John", 25);

        Person person2 = new Person("Jane", 30);

        person1.Greet();
        person1.Greet("Jas se vikam John, kako se vikas ti?");

        string person2Response = person2.RespondingBack();

        Console.WriteLine(person2Response);
        string poraka = "kolku godini imas?";
        person2.Greet(poraka);
    }
}

public class Person
{
    private string Name { get; set; }
    private int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetAge(int age)
    {
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void Greet(string message)
    {
        Console.WriteLine(message);
    }

    public string RespondingBack()
    {
        return $"Hello, my name is {Name}!";
    }
}