namespace Punten;

internal class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point { x = 10, y = 20};
        Point p2 = new Point { x = 100, y = 200 };

        p1.Show();
        p2.Show();

        //Point p3 = Point.Add(p1, p2);

        Point p3 = p1 + p2;
        p3.Show();
    }
}

class Point
{
    public int x;
    public int y;

    public static Point operator+(Point a, Point b)
    {
        return new Point { x = a.x + b.x, y = a.y + b.y};
    }

    public void Show()
    {
        Console.WriteLine($"({x}, {y})");
    }
}
