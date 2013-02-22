namespace LibraryManagement.BusinessObjects
{
    public interface ILibraryAsset
    {
        #region Instance Properties

        string Barcode { get; set; }

        #endregion

        #region Instance Methods

        void CheckIn();
        void CheckOut();
        void GetHistory();

        #endregion
    }
}