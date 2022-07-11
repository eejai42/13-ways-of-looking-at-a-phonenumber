using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract partial class USPhoneNumberBase : PhoneNumberBase
    {
        //public string AreaCode { get; set; }

        //// TODO: Implement USPhoneNumber.CentralOfficeCode property
        //public string CentralOfficeCode { get => throw new NotImplementedException(); }

        //// TODO: Implement USPhoneNumber.SubscriberNumber property
        //public string SubscriberNumber { get => throw new NotImplementedException(); }

        //// TODO: Implement USPhoneNumber.SubscriberNumber property
        //public string ExtraNumbers { get => throw new NotImplementedException(); }

        /// <summary>
        /// updated the US Phone Number
        /// </summary>
        /// <param name="e164Format"></param>
        /// <param name="expectedLength"></param>
        protected USPhoneNumberBase(string e164Format, int expectedLength) : base("US", e164Format, expectedLength)
        {
        }

        public void ParseCentralOfficeCode()
        {
            this.CentralOfficeCode = this.RemainingNumber.Substring(0, 3);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
            var excludedNumbers = new List<String>(new string[] { "411", "555", "911" });
            if (excludedNumbers.Contains(this.CentralOfficeCode)) this.AddError("CentralOfficeCode", "Excluded number in office code.");
            if (Int32.Parse($"0{this.CentralOfficeCode }") < 100) this.AddError("CentralOfficeCode", "Too low");
        }

        public void ParseSubscriberNumber()
        {
            this.SubscriberNumber = this.RemainingNumber.Substring(0, 4);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
        }

    }
}