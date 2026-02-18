namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        Jasper jasper = new Jasper();
        Egbert egbert = new Egbert();
        Erwin erwin = new Erwin();
        Bokito bokito = new Bokito();

        ACME company = new ACME();

        company.Hire(egbert);
        company.Hire(erwin);
        company.Hire(jasper);
        company.Hire(bokito);

        //company.Fire(egbert);
        company.Start();

        Console.ReadLine();
    }
}
