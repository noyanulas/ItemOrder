using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ItemOrder.Items
{
    public class Item : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public ItemType Type { get; set; }
        public OrderState State { get; set; }

        public DateTime DueDate { get; set; }

        public float PriceRange { get; set; }
        
    }
}
