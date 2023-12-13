using demoInterface.Interfaces;

namespace demoInterface.Models;

public class VoitureSport : Voiture, ISport
{
    private bool _Turbo;
    
    public bool Turbo
    {
        get { return _Turbo; }
        private set { _Turbo = value; }
    }

    public void ToggleTurbo()
    {
        Turbo = !Turbo;
    }
}