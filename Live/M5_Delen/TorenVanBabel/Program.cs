namespace TorenVanBabel;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Oerknal");

        Etage[] flat = new Etage[50];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { EtageNummer = i };
        }

        flat[34].RoepLift();


        foreach(Etage et in flat)
        {
            et.ToonLiftStatus();
        }

        //flat = null;

        //Console.WriteLine(Etage.lift.CurrentFloor);
        //Etage.lift = null;

    }
}
