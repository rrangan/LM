namespace LibraryManagement.BusinessObjects.Common
{
    public class Address : Base
    {
        #region Instance Properties

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public AddressType AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }

        #endregion
    }
}