﻿#region

using LibraryManagement.BusinessObjects.Common;

#endregion

namespace LibraryManagement.BusinessObjects
{
    public class Publisher : Base
    {
        #region Instance Properties

        public Address Address { get; set; }
        public ContactInformation ContactInformation { get; set; }
        public string Name { get; set; }

        #endregion
    }
}