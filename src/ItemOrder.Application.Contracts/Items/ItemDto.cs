using System;
using Volo.Abp.Application.Dtos;

namespace ItemOrder.Items
{
    public class ItemDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public ItemType Type { get; set; }
        public OrderState State { get; set; }
        public DateTime DueDate { get; set; }

        public float PriceRange { get; set; }
    }
}
