using ConsoleApp1.Models;

namespace ConsoleApp1
{

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
}