using ItemOrder.Items;
using AutoMapper;

namespace ItemOrder
{
    public class ItemOrderApplicationAutoMapperProfile : Profile
    {
        public ItemOrderApplicationAutoMapperProfile()
        {
            CreateMap<Item, ItemDto>();
            CreateMap<CreateUpdateItemDto, Item>();
        }
    }
}
