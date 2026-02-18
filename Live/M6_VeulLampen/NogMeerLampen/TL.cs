namespace NogMeerLampen;

// TL erft van Lamp.
// Dit heeft de volgende voordelen:
// 1) Hergebruik
// 2) Geeft de mogelijkheid om te GENERALISEREN!!!!!!!
class TL : Lamp
{
    public int Knippertijd { get; set; } = 3;

    // Met override activeer ik polymorfisme.
    // Let op: override is niet verplicht
    public override void Aan()
    {
        _intensiteit = 200;
        for (int i = 0; i < Knippertijd; i++)
        {
            Console.WriteLine("Knipperdeknipper");
            Task.Delay(300).Wait();
        }
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De TL is nu aan en brand met {Intensiteit} lumen");
    }
    public override void Uit()
    {
        Console.ResetColor();
        Console.WriteLine("De TL is nu uit.");
    }
}





