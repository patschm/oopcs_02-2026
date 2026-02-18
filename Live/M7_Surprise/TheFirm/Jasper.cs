namespace TheFirm;

class Jasper : Werknemer
{
    public void MaaktIets()
    {
        Console.WriteLine("Jasper maakt zweet");
    }

    public override void Werken()
    {
        MaaktIets();
    }
}
