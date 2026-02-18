namespace NogMeerLampen;

internal class Program
{
    static void Main(string[] args)
    {
        Lamp[] lampen = new Lamp[3] { new TL(), new DimLicht(), new TL() };
        foreach (Lamp l in lampen)
        {
            DoeAan(l);
            Console.WriteLine("stripboek");
            l.Uit();
        }


        // Hier generaliseer ik een TL naar Lamp
        Lamp t1 = new TL { Kleur = ConsoleColor.Red, Intensiteit = 300, Knippertijd = 5 };

        //(t1 as TL).Knippertijd

        //t1.Aan();
        DoeAan(t1);
        Console.WriteLine("Lees boek");
        t1.Uit();


        //Lamp l1 = new Lamp { Kleur = ConsoleColor.Yellow, Intensiteit = 1000 };
        //// l1.Aan();
        //DoeAan(l1);
        //Console.WriteLine("Lees ander boek");
        //l1.Uit();


        Lamp l3 = new DimLicht { Kleur = ConsoleColor.Green, Intensiteit = 600 };
        //l3.Aan();
        DoeAan (l3);
        for (int i = 0; i < 10;i++)
        {
            //l3.Dim(-30);
        }

        l3.Uit();
    }

    static void DoeAan(Lamp lx)
    {
        lx.Aan();
    }
}















