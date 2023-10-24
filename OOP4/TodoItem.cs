using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class TodoItem
    {
        public int Id { get; }
        public string Title { get; }
        public string Description { get; }
        public DateTime DueDate { get; }
        public bool IsComplete { get; private set; }

        public TodoItem(int id, string title, string description, DateTime dueDate)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsComplete = false;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Description: {Description}, DueDate: {DueDate}, IsComplete: {IsComplete}";
        }

        public void MarkComplete()
        {
            IsComplete = true;
        }
    }
}
