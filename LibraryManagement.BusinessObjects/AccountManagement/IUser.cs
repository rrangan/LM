#region

using System;
using LibraryManagement.BusinessObjects.Common;

#endregion

namespace LibraryManagement.BusinessObjects.AccountManagement
{
    public interface IUser
    {
        #region Instance Properties

        Address[] Address { get; set; }
        ContactInformation ContactInformation { get; set; }
        DateTime DOB { get; set; }
        string Name { get; set; }

        #endregion

        void Initialize(Guid userId);
        void Create();
        void Update();
    }
}