using System;
using ItemOrder.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ItemOrder.Items
{
    public class ItemAppService :
        CrudAppService<
            Item, //The Book entity
            ItemDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateItemDto>, //Used to create/update a book
        IItemAppService //implement the IAppService
    {
        public ItemAppService(IRepository<Item, Guid> repository)
            : base(repository)
        {
            GetPolicyName = ItemOrderPermissions.Items.Default;
            GetListPolicyName = ItemOrderPermissions.Items.Default;
            CreatePolicyName = ItemOrderPermissions.Items.Create;
            UpdatePolicyName = ItemOrderPermissions.Items.Edit;
            DeletePolicyName = ItemOrderPermissions.Items.Delete;
            //UpdateStatus= ItemOrderPermissions.Items.Manage;
        }
    }
}
