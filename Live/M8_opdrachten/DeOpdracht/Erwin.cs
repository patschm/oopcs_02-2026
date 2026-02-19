namespace DeOpdracht;

// Blauwdruk van een methode
delegate void DelNaam();

internal class Erwin
{
    public void RegelHetMaar(DelNaam iets)
    {
        Console.WriteLine("Erwin regelt het");
        iets();
    }
}
