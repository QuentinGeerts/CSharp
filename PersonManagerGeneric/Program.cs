// Créer un gestionnaire de personnes pour les étudiants et les enseignants

using PersonManagerGeneric.Models;

PersonManager<Student> studentManager = new PersonManager<Student>();
PersonManager<Teacher> teacherManager = new PersonManager<Teacher>();

// Ajouter des étudiants à la liste des étudiants
studentManager.AddPerson(new Student("Alice", 20, "E12345"));
studentManager.AddPerson(new Student("Bob", 22, "E67890"));

// Ajouter des enseignants à la liste des enseignants
teacherManager.AddPerson(new Teacher("Mr. Smith", 35, "T9876"));
teacherManager.AddPerson(new Teacher("Ms. Johnson", 40, "T5432"));

// Afficher les informations des étudiants
Console.WriteLine("Informations des étudiants :");
studentManager.DisplayInformation();

// Afficher les informations des enseignants
Console.WriteLine("\nInformations des enseignants :");
teacherManager.DisplayInformation();