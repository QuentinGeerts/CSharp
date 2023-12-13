using demoInterface.Interfaces;
using demoInterface.Models;

// Création d'une instance d'une Voiture dans une variable de type Voiture
// Fonctionne normalement, une voiture est une voiture
Voiture voiture = new Voiture();
voiture.Rouler();
voiture.Tourner();

// Création d'une instance d'une Voiture dans une variable de type Vehicule
// Fonction correctement par polymorphisme
// Une voiture est un Vehicule, donc je peux stocker son instance dedans.
// Attention que si vous stocker une voiture dans une variable Vehicule, la variable n'a
// accès qu'au membre de son type 
// Dans ce cas-ci, vous n'avez pas accès à Rouler car Rouler appartient à Voiture 
// Vehicule ne counnait que Tourner() !
Vehicule voiture2 = new Voiture();
((Voiture)voiture2).Rouler(); // Pour avoir accès à Rouler => Cast explicite!

// Création d'un garade qui possède une liste de Vehicule (polymorphisme!)
Garage monGarage = new Garage();

Voiture v1 = new Voiture();
Moto v2 = new Moto();
VoitureSport v3 = new VoitureSport();
VoitureSUV v4 = new VoitureSUV();

// Ajout d'une voiture et d'une moto (2 types différents mais un type en commun)
// List<Vehicule> => Tous les enfants peuvent y rentrer car ce sont des véhicules :)
monGarage.AddVehicule(v1);
monGarage.AddVehicule(v2);
monGarage.AddVehicule(v3);
monGarage.AddVehicule(v4);

Console.WriteLine("Bouger les voitures :");
monGarage.BougerVoiture();
// Création d'une instance d'un SUV dans une variable de type Vehicule
// Polymorphisme toujours car un SUV est un véhicule !
Vehicule vSUV = new VoitureSUV();
// Cast explicite du SUV en type ISport
// Un SUV implémente l'interface ISport et IMotrice
// Donc en plus d'être un Vehicule, il est également un ISport et IMotrice !
// L'interface dans ce cas-ci permet de mettre un filtre sur les membres d'un véhicule
// Donc accès à ToogleTurbo uniquement grâce à l'interface !
ISport vSport = (ISport)vSUV;
vSport.ToggleTurbo();

