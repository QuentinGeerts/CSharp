using CounterEvent.Models;

var compteur = new Counter();
var afficheur = new Displayer();

// Abonnement de la méthode AfficherNouvelleValeur à l'événement ValeurChangee
compteur.ChangedValue += afficheur.DisplayNewValue;

// Incrémentation du compteur (déclenche l'événement)
compteur.Increase(); // Affiche "Nouvelle valeur du compteur : 1"
compteur.Increase(); // Affiche "Nouvelle valeur du compteur : 2"

// Désabonnement de la méthode AfficherNouvelleValeur de l'événement
compteur.ChangedValue -= afficheur.DisplayNewValue;

// Incrémentation du compteur (l'événement n'est plus géré)
compteur.Increase();