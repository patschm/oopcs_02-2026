
namespace NogEenDan;

internal class Program
{
    static void Main(string[] args)
    {

        //System.Drawing.Point
        //DateTime day = DateTime.Now;
        Point p1 = new Point { X = 10, Y = 20 };
        Console.WriteLine(p1);
        DoeIets(p1);
        Console.WriteLine(p1);
    }

    private static void DoeIets(Point ppp)
    {
        ppp.X = 1000;
        ppp.Y = 2000;
    }
}
