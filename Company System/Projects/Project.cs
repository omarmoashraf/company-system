namespace Company_System.Projects;

public class Project
{
    public int ID { get; set; }
    public string Title { get; set; }
    public int[] DeveloperIDs { get; set; }
    public int DevCount { get; set; }

    public Project(int id, string title)
    {
        ID = id;
        Title = title;
        DeveloperIDs = new int[100]; 
        DevCount = 0;
    }

    public void AssignDeveloper(int developerId)
    {
        if (DevCount < DeveloperIDs.Length)
        {
            DeveloperIDs[DevCount++] = developerId;
        }
        else
        {
            Console.WriteLine("Project developer limit reached.");
        }
    }

    public void Print()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Project ID       : {ID}");
        Console.WriteLine($"Title            : {Title}");
        Console.WriteLine("Assigned Developers:");
        if (DevCount == 0)
        {
            Console.WriteLine("  - No developers assigned yet.");
        }
        else
        {
            for (int i = 0; i < DevCount; i++)
            {
                Console.WriteLine($"  - Developer ID: {DeveloperIDs[i]}");
            }
        }
        Console.WriteLine("-----------------------------\n");    }
}