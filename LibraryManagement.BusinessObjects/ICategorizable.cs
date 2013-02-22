namespace LibraryManagement.BusinessObjects
{
    public interface ICategorizable
    {
        #region Instance Properties

        Category[] Categories { get; set; }

        #endregion
    }
}