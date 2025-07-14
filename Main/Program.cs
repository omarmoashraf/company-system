using Company_System.Departments;
using Company_System.Projects;
using Company_System.Users;

namespace Main;

class Program
{
    static void Main(string[] args)
    {
         Developer[] developers = new Developer[100];
    Department[] departments = new Department[100];
    Project[] projects = new Project[100];
    int devCount = 0, depCount = 0, projCount = 0;

    bool exit = false;
    while (!exit)
    {
        Console.WriteLine("\n=== Main System Menu ===");
        Console.WriteLine("1. Add Department");
        Console.WriteLine("2. Add Developer");
        Console.WriteLine("3. Add Project");
        Console.WriteLine("4. Assign Developer to Project");
        Console.WriteLine("5. View All Departments");
        Console.WriteLine("6. View All Developers");
        Console.WriteLine("7. View All Projects");
        Console.WriteLine("8. Exit");
        Console.Write("Select an option: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Clear();
                Console.Write("Enter Department ID: ");
                int depId = int.Parse(Console.ReadLine());

                bool depExists = false;
                for (int i = 0; i < depCount; i++)
                {
                    if (departments[i].ID == depId)
                    {
                        depExists = true;
                        break;
                    }
                }

                if (depExists)
                {
                    Console.WriteLine("Error: Department ID already exists.");
                }
                else
                {
                    Console.Write("Enter Department Name: ");
                    string depName = Console.ReadLine();
                    departments[depCount++] = new Department(depId, depName);
                    Console.WriteLine("Department added successfully.");
                }
                break;

            case 2:
                Console.Clear();
                Console.Write("Enter Developer ID: ");
                int devId = int.Parse(Console.ReadLine());

                bool devExists = false;
                for (int i = 0; i < devCount; i++)
                {
                    if (developers[i].ID == devId)
                    {
                        devExists = true;
                        break;
                    }
                }

                if (devExists)
                {
                    Console.WriteLine("Error: Developer ID already exists.");
                }
                else
                {
                    Console.Write("Enter Developer Name: ");
                    string devName = Console.ReadLine();
                    Console.Write("Enter Level (Junior/Mid/Senior): ");
                    string level = Console.ReadLine();
                    Console.Write("Enter Department ID: ");
                    int depOfDev = int.Parse(Console.ReadLine());

                    bool departmentFound = false;
                    for (int i = 0; i < depCount; i++)
                    {
                        if (departments[i].ID == depOfDev)
                        {
                            departmentFound = true;
                            break;
                        }
                    }

                    if (!departmentFound)
                    {
                        Console.WriteLine("Error: Department ID does not exist. Please add the department first.");
                    }
                    else
                    {
                        
                            Console.Write("Enter Developer Salary: ");
                            double Salary = double.Parse(Console.ReadLine());

                            developers[devCount++] = new Developer(devId, devName, level, depOfDev, Salary);
                            Console.WriteLine("Developer added successfully.");
                        
                    }
                }
                break;

            case 3:
                Console.Clear();
                Console.Write("Enter Project ID: ");
                int projId = int.Parse(Console.ReadLine());

                bool projExists = false;
                for (int i = 0; i < projCount; i++)
                {
                    if (projects[i].ID == projId)
                    {
                        projExists = true;
                        break;
                    }
                }

                if (projExists)
                {
                    Console.WriteLine("Error: Project ID already exists.");
                }
                else
                {
                    Console.Write("Enter Project Title: ");
                    string projTitle = Console.ReadLine();
                    projects[projCount++] = new Project(projId, projTitle);
                    Console.WriteLine("Project added successfully.");
                }
                break;

            case 4:
                Console.Clear();
                Console.Write("Enter Project ID: ");
                int pId = int.Parse(Console.ReadLine());
                Console.Write("Enter Developer ID to Assign: ");
                int dId = int.Parse(Console.ReadLine());

                Project proj = null;
                for (int i = 0; i < projCount; i++)
                {
                    if (projects[i].ID == pId)
                    {
                        proj = projects[i];
                        break;
                    }
                }

                if (proj == null)
                {
                    Console.WriteLine("Error: Project not found.");
                }
                else
                {
                    bool devFound = false;
                    for (int i = 0; i < devCount; i++)
                    {
                        if (developers[i].ID == dId)
                        {
                            devFound = true;
                            break;
                        }
                    }

                    if (!devFound)
                    {
                        Console.WriteLine("Error: Developer not found.");
                    }
                    else
                    {
                        proj.AssignDeveloper(dId);
                        Console.WriteLine("Developer assigned to project.");
                    }
                }
                break;

            case 5:
                Console.Clear();
                Console.WriteLine("All Departments:");
                for (int i = 0; i < depCount; i++)
                    departments[i].Print();
                break;

            case 6:
                Console.Clear();
                Console.WriteLine("All Developers:");
                for (int i = 0; i < devCount; i++)
                    developers[i].Print();
                break;

            case 7:
                Console.Clear();
                Console.WriteLine("All Projects:");
                for (int i = 0; i < projCount; i++)
                    projects[i].Print();
                break;

            case 8:
                Console.Clear();
                exit = true;
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid option.");
                break;
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }
   
    }
}