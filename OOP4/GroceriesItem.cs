using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class GroceriesItem : TodoItem
    {
        private int Quantity { get; }

        public GroceriesItem(int id, string title, string description, DateTime dueDate, int quantity)
            : base(id, title, description, dueDate)
        {
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Quantity: {Quantity}";
        }
    }
}
