namespace PersonManagerGeneric.Models;

public class Teacher : Person
{
    public Teacher(string name, int age, string employeeId) : base(name, age)
    {
        EmployeeId = employeeId;
    }

    public string EmployeeId { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Identifiant Employé : {EmployeeId}";
    }
}