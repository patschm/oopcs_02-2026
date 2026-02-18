namespace TheFirm;

class Erwin : Werknemer
{
    public void Zwijgt()
    {
        Console.WriteLine("Erwin doet stilletjes zijn werk");
    }

    public override void Werken()
    {
        Zwijgt();
    }
}
