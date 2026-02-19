using Standaarden;

namespace Sick;

public class Detectielus
{
    private List<IDevice> devices = new List<IDevice>();

    public void Connect(IDevice device)
    {
        devices.Add(device); 
    }
    public void Detecteer()
    {
        Console.WriteLine("De detectielus detecteert iets");
        foreach (var device in devices)
        {
            device.Activate();
        }
    }
}
