namespace PhoneNumber_TestProject1
{
    public abstract class USPhoneNumberBase : PhoneNumberBase
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string CentralOfficeCode { get; set; }
        public string SubscriberNumber { get; set; }
        public string ExtraNumbers { get; internal set; }
        public int ExpectedLength { get; }

        protected USPhoneNumberBase(string e164Format, int expectedLength) : base(e164Format)
        {
            this.ExpectedLength = expectedLength;
        }
    }
}