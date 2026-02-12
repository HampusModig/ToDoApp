var tasks = new List<(int Id, string Title, bool Done)>();
int nextId = 1;
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

    switch (Console.ReadLine())
    {
        case "1":
            // TODO US1: Lägga till uppgift
            break;
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