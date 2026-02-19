namespace RadioStation;

internal class Program
{
    static void Main(string[] args)
    {
        Radio r538 = new Radio();
        r538.subscribers += ViaTelefoon;
        r538.subscribers += ViaSMS;
        r538.subscribers += ViaEther;
        r538.subscribers += ViaPostduif;
        r538.subscribers += ViaEmail;
        r538.subscribers += ViaTelefoon;
        r538.subscribers += ViaSMS;
        r538.subscribers += ViaEther;
        r538.subscribers += ViaPostduif;
        r538.subscribers += ViaRooksignalen;
        r538.subscribers += ViaTelefoon;
        r538.subscribers += ViaSMS;
        r538.subscribers += ViaEther;
        r538.subscribers += ViaPostduif;


        r538.Broadcast();

    }

    static void ViaSMS(string message)
    {
        Console.WriteLine($"Via SMS ontvangen: {message}");
    }
    static void ViaEmail(string message)
    {
        Console.WriteLine($"Via Email ontvangen: {message}");
    }
    static void ViaEther(string message)
    {
        Console.WriteLine($"Via Eather ontvangen: {message}");
    }
    static void ViaPostduif(string message)
    {
        Console.WriteLine($"Via Postduif ontvangen: {message}");
    }
    static void ViaTelefoon(string message)
    {
        Console.WriteLine($"Via Telefoon ontvangen: {message}");
    }
    static void ViaRooksignalen(string message)
    {
        Console.WriteLine($"Via rooksignalen ontvangen: {message}");
    }
}
