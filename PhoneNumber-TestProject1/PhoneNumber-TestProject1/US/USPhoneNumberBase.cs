using System;

namespace PhoneNumber_TestProject1
{
    public abstract class USPhoneNumberBase : PhoneNumberBase
    {
        /// <summary>
        /// The length of the expected phone number
        /// </summary>
        public int ExpectedLength { get; }

        /// <summary>
        /// A country code which is expected to be 1
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// An area within the US or canada
        /// </summary>
        public string AreaCode { get; set; }

        // TODO: Implement USPhoneNumber.CentralOfficeCode property
        public string CentralOfficeCode { get => throw new NotImplementedException(); }

        // TODO: Implement USPhoneNumber.SubscriberNumber property
        public string SubscriberNumber { get => throw new NotImplementedException(); }

        // TODO: Implement USPhoneNumber.SubscriberNumber property
        public string ExtraNumbers { get => throw new NotImplementedException(); }

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