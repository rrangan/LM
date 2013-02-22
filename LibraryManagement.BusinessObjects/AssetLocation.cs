#region

using LibraryManagement.BusinessObjects.Common;

#endregion

namespace LibraryManagement.BusinessObjects
{
    public class AssetLocation : Base
    {
        #region Instance Properties

        public Floor Floor { get; set; }
        public Library Library { get; set; }
        public Rack Rack { get; set; }

        #endregion
    }
}