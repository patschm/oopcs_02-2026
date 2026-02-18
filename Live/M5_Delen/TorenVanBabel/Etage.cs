namespace TorenVanBabel;

class Etage
{
    // Static betekent dat dit field gedeeld is door alle etage objecten
    // Statics worden ook wel class members genoemd
    // Niet statics worden instance members genoemd
    public static Lift lift = new Lift();
    public int EtageNummer { get; set; } = 0;

    public void RoepLift()
    {
        lift.Call(EtageNummer);
    }

    public void ToonLiftStatus()
    {
        //Console.WriteLine(this.EtageNummer);
        Console.WriteLine($"De lift staat op de {Etage.lift.CurrentFloor}e verdieping");
    }

}
