namespace TheFirm;

// Bokito IMPLEMENTEERT de interface IContract
class Bokito : IContract
{
    public void Werk()
    {
        Bokitogedrag();
    }

    public void Bokitogedrag()
    {
        Console.WriteLine("Bokito ramt vervelende dames in ellkaar");
    }


}
