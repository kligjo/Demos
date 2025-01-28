using System;
using System.Security.Cryptography.X509Certificates;

public class BeverageException : Exception
{
    public BeverageException() { }
    public BeverageException(string message) : base(message)
    {
    }
}

abstract class Beverage
{
    protected double Temperature { get; set; }
    public string Name { get; set; }

    public Beverage(string name, double temperature)
    {
        Name = name;
        Temperature = temperature;
    }

    public override string ToString()
    {
        return $"Beverage Name: {Name}, Temperature: {Temperature}";
    }

    public virtual string HowItsMade()
    {
        return "This is a beverage, you should boil it";
    }
}

class Tea : Beverage
{
    public string Herb { get; set; }

    public Tea(string name, double temperature, string herb)
        : base(name, temperature)
    {
        Herb = herb;
    }

    public override string ToString()
    {
        return $"Herbal Tea with Name: {Name}, Temperature: {Temperature} and is made of {Herb} leaf" +
            "\nwhile the base implementation says that \n" +
            base.ToString();
    }

    public string GetHerb()
    {
        return $"Tea's Herb is: {Herb}";
    }
}

class Coffe : Beverage
{
    public string Bean { get; set; }

    public Coffe(string name, double temperature, string bean, string dodatoci = "")
        : base(name, temperature)
    {
        Bean = bean;
    }

    public string GetCoffee()
    {
        return ToString();
    }

    public string GetCoffee(string dodatoci)
    {
        return ToString() + " \nDodatocite se :" + dodatoci;
    }

    public override string ToString()
    {
        return $"Coffee with Name: {Name}, Temperature: {Temperature} and has {Bean} beans";
    }

    public override string HowItsMade()
    {
        return "This is a coffee, you should use specialized equipment";
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the name of the beverage: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the temperature of the beverage: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the type of beverage (1 for Tea, 2 for Coffee): ");
        int type = Convert.ToInt32(Console.ReadLine());

        Beverage beverage = null;
        if (type == 1)
        {
            Console.WriteLine("Enter the herb of the tea: ");
            string herb = Console.ReadLine();

            beverage = new Tea(name, temperature, herb);
        }
        else if (type == 2)
        {
            Console.WriteLine("Enter the bean of the coffee: ");
            string bean = Console.ReadLine();
            beverage = new Coffe(name, temperature, bean);
        }

        try
        {
            if (beverage is null)
            {
                throw new BeverageException("Invalid beverage type");
            }
            Console.WriteLine("imeto na pijalokot e :" + beverage.Name);
        }
        catch(BeverageException e)
        {
            Console.WriteLine("Beverage Error: " + e.Message);
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Null reference Error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Regular Error: " + e.Message);
        }


    }
}

//class Program
//{
//    static void Main()
//    {
//        Beverage beverage1 = new Tea("caj", 100D, "Kamilica"); ;
//        Beverage beverage2 = new Tea("caj", 100D, "bosilek"); ;
//        Beverage beverage3 = new Coffe("espreso", 90, "arabika");


//        //Console.WriteLine(beverage1.ToString());
//        //Console.WriteLine(beverage3.ToString());

//        Tea justTea = (Tea)beverage1;
//        //Console.WriteLine(justTea.GetHerb());
//        //Console.WriteLine(((Tea)beverage1).GetHerb());

//        Coffe justCoffe = (Coffe)beverage3;

//        //Console.WriteLine(justTea.HowItsMade());
//        //Console.WriteLine(justCoffe.HowItsMade());

//        Console.WriteLine("this is plain Coffe: " + justCoffe.GetCoffee());
//        Console.WriteLine("this is Coffe: with Extras " + justCoffe.GetCoffee("Mleko, seker"));

//    }
//}

