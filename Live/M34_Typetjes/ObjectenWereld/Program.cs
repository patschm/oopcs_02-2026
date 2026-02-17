using System.Dynamic;

namespace ObjectenWereld;

internal class Program
{
    static void Main(string[] args)
    { 
        Lamp l1 = new Lamp();
        l1.Kleur = ConsoleColor.Yellow;
        l1.Intensiteit = 200;
       // l1.SetIntensiteit(300);

        l1.Aan();

        Console.WriteLine("FF een boek lezen");

        l1.Uit();

        Console.WriteLine(l1);


        Lamp l2 = new Lamp(ConsoleColor.Green, -400);
        l2.Aan();
        Console.WriteLine("Nog een boek");

        l2.Uit();


        Lamp l3 = new Lamp { Kleur = ConsoleColor.Green, Intensiteit = 500 };
        //l3.SetIntensiteit(400);
        l3.Aan();

        l3.Uit();


        Lamp l4 = new Lamp();
        l4.Aan();
        l4.Uit();

        Lamp l5 = new Lamp { Kleur = ConsoleColor.Red };
        // l5.SetIntensiteit(-200);
        l5.Intensiteit = -200;
        l5.Aan();
        Console.WriteLine("De wallen");
        l5.Uit();

    }
}
