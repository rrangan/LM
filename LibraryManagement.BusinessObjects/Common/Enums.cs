namespace LibraryManagement.BusinessObjects.Common
{
    public enum AddressType
    {
        Home,
        Work,
        Other
    }

    public enum AccountType
    {
        Admin,
        Librarian,
        PremiumMember,
        RegularMember
    }

    public enum AccountState
    {
        Active,
        Frozen,
        Closed
    }

    public enum AssetType
    {
        Physical,
        Digital
    }
}