namespace PersonManagerGeneric.Models;

public class Student : Person
{
    public Student(string name, int age, string studentID) : base(name, age)
    {
        StudentID = studentID;
    }

    public string StudentID { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Identifiant Étudiant : {StudentID}";
    }
}