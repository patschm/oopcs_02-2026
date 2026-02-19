using Standaarden;

namespace Sick;

public delegate void SignalHandler();


public class Detectielus
{

    public event SignalHandler? Detect;
    private List<IDevice> devices = new List<IDevice>();

    public void Connect(SignalHandler del)
    {
        Detect += del;
    }
    public void Connect(IDevice device)
    {
        devices.Add(device); 
    }
    public void Detecteer()
    {
        Console.WriteLine("De detectielus detecteert iets");
        Detect?.Invoke();

        foreach (var device in devices)
        {
            device.Activate();
        }
    }
}
