namespace HetCern;

delegate int MathDel(int x, int y);

internal class WillemKlein
{
    public void RekenUit(MathDel fun, int u, int v)
    {
        Console.WriteLine("Willem Klein begint te rekenen...");

        int result = fun(u, v);

        Console.WriteLine($"Willem kraait: Het antwoord is {result}");
    }
}
