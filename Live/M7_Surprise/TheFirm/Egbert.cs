namespace TheFirm;

class Egbert : Werknemer
{
    public void ZitTeStinken()
    {
        Console.WriteLine("Egbert zit te stinken met de voeten op tafel");
    }

    public override void Werken()
    {
        ZitTeStinken();
    }
}
