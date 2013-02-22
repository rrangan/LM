#region

using LibraryManagement.BusinessObjects.Common;

#endregion

namespace LibraryManagement.BusinessObjects
{
    public class Category : Base
    {
        #region Instance Properties

        public Category[] Children { get; set; }
        public string Name { get; set; }
        public Category Parent { get; set; }

        #endregion
    }
}