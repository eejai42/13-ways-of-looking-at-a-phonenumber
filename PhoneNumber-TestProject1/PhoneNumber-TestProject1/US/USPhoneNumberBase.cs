namespace PhoneNumber_TestProject1
{
    public abstract class USPhoneNumberBase : PhoneNumberBase
    {
        /// <summary>
        /// A country code which is expected to be 1
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// An area code which locates...
        /// </summary>
        public string AreaCode { get; set; }
        
        /// <summary>
        /// A central office code which can't be 555, 911 or 411
        /// </summary>
        public string CentralOfficeCode { get; set; }

        /// <summary>
        /// A 4 digit subscriber number
        /// </summary>
        public string SubscriberNumber { get; set; }
        
        /// <summary>
        /// Extra numbers at the end of the phone number are ignored
        /// </summary>
        public string ExtraNumbers { get; internal set; }

        /// <summary>
        /// The length of the expected phone number
        /// </summary>
        public int ExpectedLength { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e164Format"></param>
        /// <param name="expectedLength"></param>
        protected USPhoneNumberBase(string e164Format, int expectedLength) : base("US", e164Format)
        {
            this.ExpectedLength = expectedLength;
        }
    }
}