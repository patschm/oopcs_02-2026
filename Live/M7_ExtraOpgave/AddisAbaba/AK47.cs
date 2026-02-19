

using Standaarden;

namespace AddisAbaba;

public class AK47 : IDevice
{
    public void Activate()
    {
        Schiet();
    }

    public void Schiet()
    {
        Console.WriteLine("De AK47 maait overlevenden neer");
    }
}
