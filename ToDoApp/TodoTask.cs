using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    public class TodoTask
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public TodoTask(int id, string title)
        {
            Id = id;
            Title = title;
            IsCompleted = false;
        }
        public TodoTask(int id, string title, bool isCompleted)
        {
            Id = id;
            Title = title;
            IsCompleted = isCompleted;
        }

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

    }
}
