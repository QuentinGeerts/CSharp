using demoInterface.Interfaces;

namespace demoInterface.Models;

public class VoitureToutTerrain : Voiture, IMotrice
{
    private bool _Motrice = false;

    public bool Motrice
    {
        get;
        private set;
    }

    public void ToggleMotrice()
    {
        Motrice = !Motrice;
    }
}