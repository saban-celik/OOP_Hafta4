using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class ImportantItem : TodoItem
    {
        public string Priority { get; private set; }

        public ImportantItem(int id, string title, string description, DateTime dueDate, string priority)
            : base(id, title, description, dueDate)
        {
            Priority = priority;
        }

        public void PriorityLevel(string priority)
        {
            Priority = priority;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Priority: {Priority}";
            
        }
    }
}
