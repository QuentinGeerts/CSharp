namespace PersonManagerGeneric.Models;

public class Student : Person
{
    public Student(string name, int age, string studentId) : base(name, age)
    {
        StudentId = studentId;
    }

    public string StudentId { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Identifiant Étudiant : {StudentId}";
    }
}