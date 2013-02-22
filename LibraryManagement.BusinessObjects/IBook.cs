#region

using System;

#endregion

namespace LibraryManagement.BusinessObjects
{
    public interface IBook
    {
        #region Instance Properties

        string ISBN { get; set; }
        DateTime PublishDate { get; set; }
        Publisher Publisher { get; set; }
        string Summary { get; set; }
        string Title { get; set; }

        #endregion
    }
}