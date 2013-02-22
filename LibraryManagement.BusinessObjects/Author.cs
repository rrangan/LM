#region

using LibraryManagement.BusinessObjects.Common;

#endregion

namespace LibraryManagement.BusinessObjects
{
    public class Author : Base
    {
        #region Instance Properties

        public string Biography { get; set; }
        public string Name { get; set; }

        #endregion
    }
}