using System.Threading.Tasks;
using ToDoApp;


public class Program
{
    public static bool InputValidator(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Ogiltig input. Försök igen!");
            return false;
        }
        return true;
    }
    public static void DisplayMenu()
    {
        TaskManager taskManager = new TaskManager();

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("\n=== ToDo-Lista ===");
            Console.WriteLine("1. Lägg till");
            Console.WriteLine("2. Sök och filtrera");
            Console.WriteLine("3. Markera klar");
            Console.WriteLine("4. Ta bort");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj: ");

            switch (Console.ReadLine())
            {
                case "1":
                    string title;
                    do
                    {
                        Console.Write("Ange titel för uppgiften: ");
                        title = Console.ReadLine();
                    } 
                    while (!InputValidator(title));

                    taskManager.AddTask(title);
                    Console.WriteLine("Uppgift tillagd!");
                    break;

                case "2":
                    // TODO US2: Visa alla uppgifter
                    Console.WriteLine("1. Visa alla");
                    Console.WriteLine("2. Visa uppgifter som är klara");
                    Console.WriteLine("3. Visa uppgifter som inte är klara");
                    switch(Console.ReadLine())
                    {
                        case "1":
                            Console.Clear();
                            if (taskManager.Tasks.Count() == 0)
                            {
                                Console.WriteLine("Inga uppgifter att visa.");
                                break;
                            }
                            taskManager.DisplayAllTasks();
                            break;
                            case "2":
                            taskManager.DisplayTaskByStatus(true);
                            break;
                            case "3":
                            taskManager.DisplayTaskByStatus(false);
                            break;
                            
                    }
                    break;
                case "3":
                    Console.Clear();
                    bool validInput = int.TryParse(Console.ReadLine(), out int id);
                    while (!validInput)
                    {
                        Console.WriteLine("Ogiltig input. Ange ett giltigt ID:");
                        validInput = int.TryParse(Console.ReadLine(), out id);
                    }
                    taskManager.CompleteTask(id);
                    break;

                case "4":
                    // TODO US4: Ta bort uppgift
                    Console.Clear();
                    taskManager.DisplayAllTasks();
                    Console.Write("Ange ID för uppgiften du vill ta bort: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                    {
                        taskManager.DeleteTask(deleteId);
                        Console.WriteLine("Uppgift borttagen!");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt ID, försök igen.");
                    }
                    break;
                case "0":
                    running = false;
                    FileManager.WriteToFile("tasks.txt", taskManager.Tasks);
                    break;
                default:
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    break;
            }
            Console.WriteLine("Tryck på Enter för att fortsätta...");
            Console.ReadLine();
        }
    }
    public static void Main()
    {

        DisplayMenu();

    }
}