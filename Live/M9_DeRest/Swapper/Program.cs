
using System.Collections;

namespace Swapper;

internal class Program
{
    static void Main(string[] args)
    {
        object[] lijst = new object[5] { 1, 2, 3, 4, 5 };

        //ArrayList list = new ArrayList();
        //list.Add(1);
        //list.Add(2);
        //list.Add(3);
        //list.Add("4");

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
       // list.Add("4");

        foreach(int i in list)
        {
            Console.WriteLine(i);
        }


        // Generics
        Point<int> point = new Point<int> { X = 10, Y = 20 };
        Console.WriteLine(point);

       


        decimal a = 10;
        decimal b = 20;

        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    static void Swap<T>(ref T aa, ref T bb) where T: IFormattable
    {
        T tmp = aa;
        aa = bb;
        bb = tmp;
    }
    static void Swap(ref double aa, ref double bb)
    {
        double tmp = aa;
        aa = bb;
        bb = tmp;
    }
    static void Swap(ref float aa, ref float bb)
    {
        float tmp = aa;
        aa = bb;
        bb = tmp;
    }
    static void Swap(ref long aa, ref long bb)
    {
        long tmp = aa;
        aa = bb;
        bb = tmp;
    }
    static void Swap(ref int aa, ref int bb)
    {
        int tmp = aa;
        aa = bb;
        bb = tmp;
    }
}
