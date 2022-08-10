using ItemOrder.Items;
using AutoMapper;

namespace ItemOrder.Blazor
{
    public class ItemOrderBlazorAutoMapperProfile : Profile
    {
        public ItemOrderBlazorAutoMapperProfile()
        {
            CreateMap<ItemDto, CreateUpdateItemDto>();
        }
    }
}
