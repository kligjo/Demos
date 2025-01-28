
public static class StringExnestions
{
    public static string CapitalizeFirst(this string text)
    {
        var firstLetter = text.Substring(0, 1).ToUpper(); ;
        var rest = text.Substring(1);
        return firstLetter + rest;
    }
}

class Coffee
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Price { get; set; }
    public Coffee(string name, string type, int price)
    {
        Name = name;
        Type = type;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} {Type} {Price}";
    }

}

class Program
{
    static void Main()
    {
        //list<int> niza1 = [1, 2, 3, 4, 5];
        //list<int> niza2 = [6, 7, 8, 9, 10];

        //list<string> niza3 = ["a", "b", "c", "d", "e"];
        //list<string> niza4 = ["f", "g", "h", "i", "j"];

        //list<coffee> niza5 = new list<coffee>();
        //niza5.add(new coffee("espresso", "strong", 100));
        //niza5.add(new coffee("cappuccino", "medium", 150));
        //niza5.add(new coffee("latte", "light", 200));

        //list<coffee> niza6 = [new coffee("espresso", "strong", 150), new coffee("espresso", "strong", 522), new coffee("espresso", "strong", 100)];

        //list<int> kombinirananiza = combinelists<int>(niza1, niza2);

        //for (int i = 0; i < kombinirananiza.count; i++)
        //{
        //    console.writeline(kombinirananiza[i]);
        //}

        //list<string> kombinirananiza2 = combinelists<string>(niza3, niza4);
        //for (int i = 0; i < kombinirananiza2.count; i++)
        //{
        //    console.writeline(kombinirananiza2[i]);
        //}

        //list<coffee> kombinirananiza3 = combinelists<coffee>(niza5, niza6);
        //for (int i = 0; i < kombinirananiza3.count; i++)
        //{
        //    console.writeline(kombinirananiza3[i]);
        //}


        //extensions
        string text = "hello World";

        Console.WriteLine(text.CapitalizeFirst());

        string text2 = "jas sum Kliment";
        Console.WriteLine(text2.CapitalizeFirst());


    }

    public static List<T> combineLists<T>(List<T> niza1, List<T> niza2)
    {
        List<T> kombiniranaNiza = new List<T>(); ;


        //prefrli ja prvata niza vo kombiniranata niza
        foreach (T element in niza1)
        {
            kombiniranaNiza.Add(element);
        }

        //prefrli ja vtorata niza vo kombiniranata niza
        for (int i = 0; i < niza2.Count; i++)
        {
            kombiniranaNiza.Add(niza2[i]);
        }

        return kombiniranaNiza;
    }

}

