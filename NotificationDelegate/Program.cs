using NotificationDelegate.Models;

static void Main()
{
    NotificationService notificationService = new NotificationService();

    // Enregistrer des méthodes de notification personnalisées
    notificationService.RegisterNotification(SendEmail);
    notificationService.RegisterNotification(SendSMS);

    // Envoyer des notifications
    notificationService.SendNotification("Notification par email : Bonjour !");
    notificationService.SendNotification("Notification par SMS : Bonjour !");
}

static void SendEmail(string message)
{
    Console.WriteLine("Envoi d'email : " + message);
}

static void SendSMS(string message)
{
    Console.WriteLine("Envoi de SMS : " + message);
}