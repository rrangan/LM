#region

using System;
using LibraryManagement.BusinessObjects.Common;

#endregion

namespace LibraryManagement.BusinessObjects.AccountManagement
{
    public class Account : Base
    {
        #region Instance Properties

        public DateTime OpenDate { get; set; }
        public AccountType Type { get; set; }
        public IUser User { get; set; }
        public AccountState State { get; set; }
        #endregion

        /// <summary>
        /// Creates the account.
        /// </summary>
       public void Create()
       {
           throw new NotImplementedException();
       }

       /// <summary>
       /// Gets the account by user.
       /// </summary>
       /// <param name="user">The user.</param>
        public void Initialize(IUser user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the account by account id.
        /// </summary>
        /// <param name="accountId">The account id.</param>
        public void Initialize(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void ChangeState(AccountState state)
        {
            throw new NotImplementedException();
        }
    }
}