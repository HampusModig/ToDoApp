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
/* 
        * 1. Skapa TodoTask-klass med properties (Id, Title, IsCompleted)
        * 2. Skapa metod AddTask() i TaskManager-klass
        * 3. Skapa menyval för "Lägg till uppgift"
        * 4. Implementera input-validering (tom titel)
        * 5. Testa funktionalitet
✓ Användaren kan välja "Lägg till uppgift" från huvudmenyn​
✓ Programmet ber om en titel för uppgiften​
✓ Uppgiften läggs till i listan med ett unikt ID​
✓ Ett bekräftelsemeddelande visas​
✓ Tom titel ska avvisas med felmeddelande​
✓ Nya uppgifter är automatiskt "inte klara" (IsCompleted = false)
*/
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