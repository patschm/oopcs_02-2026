using AddisAbaba;
using DoomsdayPreppers;
using Heras;
using Logitech;
using Sick;

namespace Oprijlaan;

class Program
{
    static void Main(string[] args)
    {
        Detectielus lus = new();
        Hek hek = new Hek();
        Valkuil kuil = new Valkuil();
        Camera cam = new Camera();
        AK47 gun = new();
        


        lus.Detect += hek.Open;
        lus.Detect += cam.Start;
        lus.Detect += kuil.Open;
        lus.Detect += gun.Schiet;

        lus.Connect(hek.Open);
        lus.Connect(cam.Start);
        lus.Connect(kuil.Open);
        lus.Connect(gun.Schiet);


        lus.Connect(hek);
        lus.Connect(cam);
        lus.Connect(kuil);
        lus.Connect(gun);


        // Hier komen de boze cursisten
        lus.Detecteer();
        //hek.Open(); // FOUT!!!
    }
}
