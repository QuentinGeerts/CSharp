using demoInterface.Interfaces;

namespace demoInterface.Models;

public class VoitureSUV : Voiture, ISport, IMotrice
{
    public bool Turbo { get; private set; }
    public void ToggleTurbo()
    {
        Turbo = !Turbo;
    }

    private bool _Motrice;
    public bool Motrice { get { return _Motrice; } }
    public void ToggleMotrice()
    {
        _Motrice = !_Motrice;
    }
}