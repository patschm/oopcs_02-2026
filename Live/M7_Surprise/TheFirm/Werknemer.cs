namespace TheFirm;

class Werknemer : Persoon, IContract
{
    public void Werk()
    {
        Werken();
    }

    public virtual void Werken()
    {
        
    }
}
