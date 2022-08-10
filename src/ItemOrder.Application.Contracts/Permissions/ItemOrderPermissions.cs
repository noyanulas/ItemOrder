namespace ItemOrder.Permissions;

public static class ItemOrderPermissions
{
    public const string GroupName = "ItemOrder";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public static class Items
    {
        public const string Default = GroupName + ".Items";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string Manage = Default + ".Manage";
    }
}