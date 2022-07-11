using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract partial class USPhoneNumberBase : PhoneNumberBase
    {
        public string CountryCode { get; set; }

        public string AreaCode { get; set; }
        public string CentralOfficeCode { get; set; }
        public string SubscriberNumber { get; set; }
        public string ExtraNumbers { get; set; }

        /// <summary>
        /// updated the US Phone Number
        /// </summary>
        /// <param name="e164Format"></param>
        /// <param name="expectedLength"></param>
        protected USPhoneNumberBase(string e164Format, int expectedLength) : base("US", e164Format, expectedLength)
        {
        }

        /// <summary>
        /// Strip the area ocde off of the number
        /// </summary>
        public void ParseAreaCode()
        {
            this.AreaCode = this.Take(3);
        }

        /// <summary>
        /// Check if the first code is a 1 - indicating that the countrycode was dialed
        /// </summary>
        public void ParseCountryCode()
        {
            this.CountryCode = "1";
            if (this.RemainingNumber.StartsWith("1")) this.Take(1);
        }
    }
}