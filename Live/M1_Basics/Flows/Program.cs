using System.Threading.Channels;

namespace Flows;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine("Waar");
        }
        else if (args.Length == 5)
        {

        }
        else
        {

        }

        int x = 2;

        switch (x)
        {
            case 0:
                Console.WriteLine("nul");
               break;
            case 1:
                Console.WriteLine("een");
                break;
            case 2:
                Console.WriteLine("twee");
                break;

            default:
                Console.WriteLine("anders");
                break;
        }

        int s = 0;
        for (Console.WriteLine("init"); s < 10; Console.WriteLine("Einde iteratie"))
        {
            if (++s == 5) break;
            Console.WriteLine(s);
        }
        Console.WriteLine(s);


        // wordt 0 of meer keer uitgevoerd
        while(s < 10)
        {
            Console.WriteLine($"While.... {++s}");
        }


        string name = null;

        // Wordt 1 of meer keer uitgevoerd
        do
        {

            Console.WriteLine($"Do... {s++}");
        }
        while (s < 10);
    }
}










