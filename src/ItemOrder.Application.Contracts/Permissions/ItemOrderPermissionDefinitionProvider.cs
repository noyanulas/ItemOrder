using ItemOrder.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ItemOrder.Permissions;

public class ItemOrderPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {

        var ItemOrderGroup = context.AddGroup(ItemOrderPermissions.GroupName, L("Permission:ItemOrder"));

        var itemsPermission = ItemOrderGroup.AddPermission(ItemOrderPermissions.Items.Default, L("Permission:Items"));
        itemsPermission.AddChild(ItemOrderPermissions.Items.Create, L("Permission:Items.Create"));
        itemsPermission.AddChild(ItemOrderPermissions.Items.Edit, L("Permission:Items.Edit"));
        itemsPermission.AddChild(ItemOrderPermissions.Items.Delete, L("Permission:Items.Delete"));
        itemsPermission.AddChild(ItemOrderPermissions.Items.Manage, L("Permission:Items.Manage"));


    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ItemOrderResource>(name);
    }
}
