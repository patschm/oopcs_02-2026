namespace NogMeerLampen;

// Sealed. Kan n iet meer van deze class erfen.
sealed class DimLicht : Lamp
{
    public void Dim(int amount)
    {
        Intensiteit += amount;
        Console.WriteLine($"Het dimicht is nu aan en brand met {Intensiteit} lumen");
    }

    public override void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"Het dimicht is nu aan en brand met {Intensiteit} lumen");
    }
    public override void Uit()
    {
        Console.ResetColor();
        Console.WriteLine("Het Dimlicht is nu uit.");
    }
}
