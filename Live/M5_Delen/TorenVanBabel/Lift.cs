namespace TorenVanBabel;

class Lift
{
    public int CurrentFloor = 0;

    public void Call(int floor)
    {
        Console.WriteLine($"De lift zoemt naar de {floor}e verdieping");
        CurrentFloor = floor; 
    }
}