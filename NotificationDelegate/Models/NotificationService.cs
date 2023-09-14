namespace NotificationDelegate.Models;

// Définition du délégué pour les méthodes de notification
public delegate void NotificationDelegate(string message);

// Classe de service de notification
public class NotificationService
{
    // Délégué pour la méthode de notification
    private NotificationDelegate notificationMethod;

    // Méthode pour enregistrer la méthode de notification
    public void RegisterNotification(NotificationDelegate method)
    {
        notificationMethod += method;
    }

    // Méthode pour envoyer une notification
    public void SendNotification(string message)
    {
        if (notificationMethod != null) notificationMethod(message);
    }
}