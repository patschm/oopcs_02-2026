

using System.Diagnostics;

namespace FuncsAndProcs;

internal class Program
{
    static void Main(string[] args)
    {
        var res = TelOp(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        Console.WriteLine(res);

        ToonWelkomsScherm();
        double a = GeefEenGetal(labeltext: "Give number");
        double b = GeefEenGetal("B");
        var bla = TelOp(a, b);
        ToonResultaat(bla);
        ToonAfscheidsScherm();
    }

    /// <summary>
    /// Toont het afscheidsscherm
    /// <code>
    /// ToonAfscheidsScherm();   
    /// </code>
    /// </summary>
    static void ToonAfscheidsScherm()
    {
        Console.WriteLine("Nou! Tot ziens maar weer");
    }


    // Procedure
    /// <summary>
    /// Toont welkomsscherm
    /// </summary>
    static void ToonWelkomsScherm()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Welkom rekenwonder.");
        Console.ResetColor();
    }

    static double GeefEenGetal(string label = "A", string labeltext = "Geeft getal")
    {
        do
        {
            Console.WriteLine($"{labeltext} {label}");
            string? sGetal = Console.ReadLine();
            int value;
            if (ConvertInput(sGetal, out value))
                return value;
            Console.WriteLine("Foutieve invoer");
        }
        while (true);
    }

    static bool ConvertInput(string? sGetal, out int nummer)
    {
        nummer = 0;
        try
        {
            nummer = int.Parse(sGetal);
            return true;
        }
        catch (Exception e)
        {
            Debug.WriteLine(e);
        }
        return false;
    }

    /// <summary>
    /// Telt twee integers op
    /// </summary>
    /// <param name="a">Eerste getal</param>
    /// <param name="b">Tweede getal</param>
    /// <returns>De som van de twee getallen</returns>
    static int TelOp(int a, int b)
    {
        Console.WriteLine("We gaan optellen...");
        return a + b;
    }

    // Overload
    static double TelOp(double a, double b)
    {
        return a + b;
    }
    static double TelOp(params double[] getallen)
    {
        return getallen.Sum();
    }

    static void ToonResultaat(int result)
    {
        Console.WriteLine($"Het resultaat is {result}");
    }
    static void ToonResultaat(double result)
    {
        Console.WriteLine($"Het resultaat is {result}");
    }
}


