using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class TodoList
    {
        private List<TodoItem> Items;

        public TodoList()
        {
            Items = new List<TodoItem>();
        }

        public TodoList(List<TodoItem> items)
        {
            Items = items;
        }

        public void AddItem(TodoItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(int id)
        {
            TodoItem item = Items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                Items.Remove(item);
            }
        }

        public void MarkComplete(int id)
        {
            TodoItem item = Items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                item.MarkComplete();
            }
        }

        public List<TodoItem> GetDueItems(DateTime dueDate)
        {
            return Items.Where(item => item.DueDate < dueDate).ToList();
        }

        public List<TodoItem> GetItems()
        {
            return Items;
        }

        public TodoItem GetOneItem(int id)
        {
            return Items.FirstOrDefault(item => item.Id == id);
        }

        public void DisplayTasks()
        {
            foreach (TodoItem item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
