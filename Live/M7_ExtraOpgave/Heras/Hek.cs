using Standaarden;

namespace Heras;

public class Hek : IDevice
{
    public void Activate()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Het hek gaar open");
    }
}
