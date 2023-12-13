// Les exceptions sont utilisées pour gérer les erreurs qui se produisent
// pendant l'exécution d'un programme.

// Elles sont des objets qui héritent de la classe "System.Exception"

// try : Ce bloc est utilisé pour envelopper le code qui peut générer potentiellement
//       une exception

// catch : Ce bloc est utilisé pour capturer et gérer une exception

// finally : Ce bloc est exécuté après les blocs try / catch
//           Il est souvent utilisé pour nettoyer les ressources

using demoExceptions.Exceptions;

try
{
    // int x = int.Parse((long.MaxValue / 2).ToString());
    // int x = int.Parse(null);
    int x = int.Parse("a");
}
catch (OverflowException ex)
{
    Console.WriteLine("Overflow : " + ex.Message);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Null : " + ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Format : " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Exception : " + ex.Message);
}
finally
{
    Console.WriteLine("Finally");
}

Console.WriteLine("Terminé");

// De manière plus propre
try
{
    int x = int.Parse("a");
}
catch (Exception e)
{
    switch (e)  
    {
        case ArgumentNullException:
            Console.WriteLine("Null : " + e.Message);
            break;
        
        case FormatException:
            Console.WriteLine("Format : " + e.Message);
            break;
        
        case OverflowException:
            Console.WriteLine("Overflow : " + e.Message);
            break;
    }
}

// Vous pouvez utiliser le mot clef "throw" pour lever une exception

try
{
    throw new InvalidOperationException("Une erreur s'est produite");
}
catch (InvalidOperationException e)
{
    Console.WriteLine("Erreur : " + e.Message);
}

// Vous pouvez créer vos propres types d'exceptions en héritant de la classe Exception, ...

try
{
    throw new MyException("Ceci est mon exception personnalisée");
}
catch (MyException e)
{
    Console.WriteLine("Erreur : " + e.Message);
} 





