namespace demoInterface.Models;

public class Garage
{
    private readonly List<Vehicule> _vehicules = new();

    /// <summary>
    /// Exemple de docummentation : taper /// au-dessus d'une méthode et hop :)
    /// </summary>
    /// <param name="vehicule"></param>
    /// <exception cref="ArgumentNullException">
    /// Car t'as rien mis andouille !
    /// </exception>
    public void AddVehicule(Vehicule vehicule)
    {
        // Toujours tester ce qui pourrait poser problème !
        if (vehicule == null) throw new ArgumentNullException("vehicule");
        // Ensuite établir la logique métier
        // Ajout du véhicule
        // (Voiture, VoitureSport, VoitureSUV, Moto, VoitureToutTerrain, Vehicule)
        _vehicules.Add(vehicule);
    }

    public void BougerVoiture()
    {
        foreach (var vehicule in _vehicules)
        {
            // if (vehicule is Voiture)
            if (vehicule is Voiture voiture) // Pattern Matching :)
            {
                // Voiture
                // ((Voiture)vehicule).Rouler();
                voiture.Rouler();
            }

            if (vehicule is Moto moto)
            {
                // Moto
                // ((Moto)vehicule).Rouler();
                moto.Rouler();
            }
        }
    }
}