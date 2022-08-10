using System;
using System.Threading.Tasks;
using ItemOrder.Items;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ItemOrder
{
    public class ItemOrderDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Item, Guid> _itemRepository;

        public ItemOrderDataSeederContributor(IRepository<Item, Guid> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _itemRepository.GetCountAsync() <= 0)
            {
                await _itemRepository.InsertAsync(
                    new Item
                    {
                        Name = "Laptop",
                        Type = ItemType.Teknoloji,
                        DueDate = new DateTime(2022, 11, 24),
                        PriceRange = 19.84f,
                        State = OrderState.Sonucsuz
                    },
                    autoSave: true
                );

                await _itemRepository.InsertAsync(
                    new Item
                    {
                        Name = "Tükenmez Kalem",
                        Type = ItemType.Malzeme,
                        DueDate = new DateTime(2022, 9, 12),
                        PriceRange = 40,
                        State = OrderState.Sonucsuz
                    },
                    autoSave: true
                );
            }
        }
    }
}
