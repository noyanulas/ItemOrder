using System;
using System.ComponentModel.DataAnnotations;

namespace ItemOrder.Items
{
    public class CreateUpdateItemDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public ItemType Type { get; set; } = ItemType.Belirsiz;
        [Required]
        public OrderState State { get; set; } = OrderState.Sonucsuz;
        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; } = DateTime.Now;

        [Required]
        public float PriceRange{ get; set; }
    }
}
