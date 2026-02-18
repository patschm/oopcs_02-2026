
namespace NogMeerLampen;

abstract class Lamp
{
    protected int _intensiteit = 300;
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Cyan;

    public int Intensiteit
    {
        get
        {
            return _intensiteit;
        }
        set
        {
            if (value >= 0 && value < 2000)
            {
                _intensiteit = value;
            }
            else
            {
                Console.WriteLine($"Ongeldige waarde {value}");
            }
        }
    }


    // Met virtual maak ik dit gedrag polymorf-ready
    public virtual void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lampp is nu aan en brand met {Intensiteit} lumen");
    }

    // Met abstract MOET een afgeleide class een override doen.
    public abstract void Uit();
    //{
    //    Console.ResetColor();
    //    Console.WriteLine("De lamp is nu uit.");
    //}
}





