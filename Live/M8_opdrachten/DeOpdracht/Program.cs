namespace DeOpdracht;

internal class Program
{
    static void Main(string[] args)
    {
        Patrick pat = new Patrick();
        Erwin erwin = new Erwin();

        //pat.Bestelling();
        erwin.RegelHetMaar(pat.Bestelling);
        erwin.RegelHetMaar(Explodeer);
    }

    static void Explodeer()
    {
        Console.WriteLine("Kabooom!!!!");
    }
}
