
namespace ConsoleApp1.Models
{
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
}
