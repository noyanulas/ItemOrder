using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace ItemOrder.Items
{
    public class ItemAppService_Tests : ItemOrderApplicationTestBase
    {
        private readonly IItemAppService _itemAppService;

        public ItemAppService_Tests()
        {
            _itemAppService = GetRequiredService<IItemAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Items()
        {
            //Act
            var result = await _itemAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.Name == "Laptop");
        }

        [Fact]
        public async Task Should_Create_A_Valid_Item()
        {
            //Act
            var result = await _itemAppService.CreateAsync(
                new CreateUpdateItemDto
                {
                    Name = "Sandalye",
                    PriceRange = 35,
                    DueDate = DateTime.Now,
                    Type = ItemType.Mobilya
                }
            );

            //Assert
            result.Id.ShouldNotBe(Guid.Empty);
            result.Name.ShouldBe("Sandalye");
        }

        [Fact]
        public async Task Should_Not_Create_A_Item_Without_Name()
        {
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _itemAppService.CreateAsync(
                    new CreateUpdateItemDto
                    {
                        Name = "Printer",
                        PriceRange = 10,
                        DueDate = DateTime.Now,
                        Type = ItemType.Ofis_Aleti
                    }
                );
            });

            exception.ValidationErrors
                .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
        }
    }
}
