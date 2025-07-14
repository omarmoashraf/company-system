using Company_System.Projects;

namespace Company_System.Users;

public class Developer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Level { get; set; } 
    public int DepartmentID { get; set; }
    
    public double salary { get; set; }

    public Developer(int id, string name, string level, int departmentId , double salary)
    {
        ID = id;
        Name = name;
        Level = level;
        DepartmentID = departmentId;
        salary = salary;
    }

    public void Print()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Developer ID     : {ID}");
        Console.WriteLine($"Name             : {Name}");
        Console.WriteLine($"Level            : {Level}");
        Console.WriteLine($"Department ID    : {DepartmentID}");
        Console.WriteLine($"Salary           : {salary} EGP");
        Console.WriteLine("-----------------------------\n");    }
    
}