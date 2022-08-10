using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ItemOrder.Items
{
    public interface IItemAppService :
        ICrudAppService< //Defines CRUD methods
            ItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateItemDto> //Used to create/update a book
    {

    }
}
