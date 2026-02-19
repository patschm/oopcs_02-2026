using Standaarden;

namespace Logitech;

public class Camera : IDevice
{
    public void Activate()
    {
        Start();
    }

    public void Start()
    {
        Console.WriteLine("De camera start de live stream");
    }
}
