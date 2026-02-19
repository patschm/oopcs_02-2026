namespace RadioStation;

delegate void OntvangstDel(string msg);

internal class Radio
{
    public event OntvangstDel subscribers;

    public void Broadcast()
    {
        Console.WriteLine("We gaan uitzenden");
        subscribers?.Invoke("Hallo luisteraars");
    }
}
