// En C#, Func et Action sont deux types de délégués génériques utilisés pour représenter des méthodes anonymes ou des fonctions lambda.
// La principale différence entre Func et Action réside dans leur signature de méthode et leur utilisation.

// Func :
// - Func est un délégué générique qui prend un ou plusieurs paramètres d'entrée et renvoie une valeur de retour.
// - Il est utilisé pour définir des méthodes ou des fonctions qui effectuent un calcul et renvoient un résultat.
// - La dernière spécification de type générique de Func est la valeur de retour de la méthode, et les précédentes
//   spécifications sont les types de paramètres d'entrée.
//   Par exemple, Func<int, string, bool> représente une méthode prenant un entier et une chaîne en entrée et renvoyant un booléen en sortie.

// Action :
// - Action est un délégué générique qui prend un ou plusieurs paramètres d'entrée, mais il ne renvoie pas de valeur
//   (c'est-à-dire qu'il a une signature de méthode "void").
// - Il est utilisé lorsque vous souhaitez exécuter une opération sans renvoyer de résultat.
// - La spécification de type générique d'Action représente les types de paramètres d'entrée.
//   Par exemple, Action<int, string> représente une méthode prenant un entier et une chaîne en entrée, mais ne renvoyant rien.

// Exemple avec Func : addition de deux nombres et renvoi du résultat.

static int Add(int x, int y)
{
    return x + y;
}

// Exemple avec Action : affichage d'un message à la console.
static void PrintMessage(string message)
{
    Console.WriteLine(message);
}

static void Main()
{
    // Utilisation de Func pour effectuer une addition.
    Func<int, int, int> addFunc = Add;
    int sum = addFunc(5, 3);
    Console.WriteLine("Résultat de l'addition : " + sum); // Affiche "Résultat de l'addition : 8"

    // Utilisation de Action pour afficher un message.
    Action<string> printAction = PrintMessage;
    printAction("Bonjour, C# !"); // Affiche "Bonjour, C# !"
}