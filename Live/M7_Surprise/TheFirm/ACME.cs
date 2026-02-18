namespace TheFirm;

class ACME
{

    private List<IContract> werknemers = new List<IContract>();

    public void Hire (IContract werknemer)
    {
        werknemers.Add(werknemer);
    }
    public void Fire(IContract werknemer)
    {
        werknemers.Remove(werknemer);
    }
    public void Start()
    {
        Console.WriteLine("ACME gaat produceren.");
        Console.Beep(2000, 1000);
        foreach (IContract wn in werknemers)
        {
            wn.Werk();
        }

    }
}
