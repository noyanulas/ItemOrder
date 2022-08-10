using System.Threading.Tasks;
using ItemOrder.Localization;
using ItemOrder.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace ItemOrder.Blazor.Menus;

public class ItemOrderMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<ItemOrderResource>();
        var siparisSayfasi = context.Menu.GetAdministration();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ItemOrderMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )

        );


        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        var Administration = context.Menu.GetAdministration();
        




        context.Menu.AddItem(
             new ApplicationMenuItem(
                "Siparisler",
                 l["Menu:Items"],
                 icon: "fa fa-book"
              ).AddItem(
               new ApplicationMenuItem(
                "SatinAlim",
                 l["Menu:SatinAlim"],
                 url: "/SatinAlim"
              )

          )
        );
        

        return Task.CompletedTask;
    }
}
