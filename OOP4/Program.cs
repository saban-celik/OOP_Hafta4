using OOP4;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        TodoList list = new TodoList();
        list.AddItem(new TodoItem(1, "Task 1", "Description 1", DateTime.Now.AddDays(2)));
        list.AddItem(new ImportantItem(4, "Important Task", "Description 4", DateTime.Now.AddDays(3), "High"));
        list.AddItem(new GroceriesItem(5, "Groceries", "Description 5", DateTime.Now.AddDays(4), 10));
        list.AddItem(new UrgentItem(6, "Urgent Task", "Description 6", DateTime.Now.AddDays(1), "Critical", true));

        Console.WriteLine("All Tasks:");
        list.DisplayTasks();

        DateTime currentDate = DateTime.Now;
        Console.WriteLine("\nDue Tasks:");
        List<TodoItem> dueTasks = list.GetDueItems(currentDate);
        foreach (TodoItem item in dueTasks)
        {
            Console.WriteLine(item);
        }
    }
}
