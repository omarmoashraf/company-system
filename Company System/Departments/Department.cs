namespace Company_System.Departments;

public class Department
{
    public int ID { get; set; }
    public string Name { get; set; }

    public Department(int id, string name)
    {
        ID = id;
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Department ID    : {ID}");
        Console.WriteLine($"Name             : {Name}");
        Console.WriteLine("-----------------------------\n");    }
}