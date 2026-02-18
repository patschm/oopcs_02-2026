
namespace ObjectenWereld;

// Blauwdruk van een lamp
class Lamp
{
    // Eigenschappen definieer je in fields
    // By default zijn alle members private
    private int _intensiteit = 300;
    //private ConsoleColor _kleur = ConsoleColor.Gray;


    // Encapsulation. Caveman style want in dotnet doen we dit met properties
    //public void SetIntensiteit(int intensiteit)
    //{
    //    if (intensiteit >= 0 && intensiteit < 2000)
    //    {
    //        _intensiteit = intensiteit;
    //    }
    //    else
    //    {
    //        Console.WriteLine($"Ongeldige waarde {intensiteit}");
    //    }
    //}
    //public int GetIntensiteit()
    //{
    //    return _intensiteit;
    //}


    // Auto generating property. Genereert zijn eigen private field
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Gray;

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

    // Gedrag definieer je in functions/procedures. In deze specifieke sitiuatie noemen we die METHODS
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lampp is nu aan en brand met {Intensiteit} lumen");
        // Console.ResetColor();
    }
    public void Uit()
    {
        Console.ResetColor();
        Console.WriteLine("De lamp is nu uit.");
    }

    // Construction.
    // Het doel is om FIELDS een initiele waarde te geven
    public Lamp(ConsoleColor kleur, int intensiteit)
    {
        Kleur = kleur;
        Intensiteit = intensiteit;
    }
    public Lamp() //: this(ConsoleColor.Yellow, 200)
    {

    }
}





