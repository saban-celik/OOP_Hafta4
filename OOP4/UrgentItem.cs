using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    class UrgentItem : ImportantItem
    {
        public bool IsUrgent { get; private set; }

        public UrgentItem(int id, string title, string description, DateTime dueDate, string priority, bool isUrgent)
            : base(id, title, description, dueDate, priority)
        {
            IsUrgent = isUrgent;
        }

        public void SetIsUrgent(bool isUrgent)
        {
            IsUrgent = isUrgent;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, IsUrgent: {IsUrgent}";
        }
    }
}
