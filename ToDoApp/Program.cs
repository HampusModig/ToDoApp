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
            Console.WriteLine("\n=== ToDo-Lista ===");
            Console.WriteLine("1. Lägg till");
            Console.WriteLine("2. Visa alla");
            Console.WriteLine("3. Markera klar");
            Console.WriteLine("4. Ta bort");
            Console.WriteLine("0. Avsluta");
            Console.Write("Välj: ");
            string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                    //TODO US1: Lägg till uppgift                
                    case "2":
                        // TODO US2: Visa alla uppgifter
                        break;
                    case "3":
                        // TODO US3: Markera som klar
                        break;
                    case "4":
                        // TODO US4: Ta bort uppgift
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
        }
    }
    public static void Main()
    {

        DisplayMenu();

    }
}