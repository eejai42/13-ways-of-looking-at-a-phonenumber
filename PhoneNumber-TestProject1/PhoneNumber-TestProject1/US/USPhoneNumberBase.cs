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

        internal void ParseCentralOfficeCode()
        {
            this.CentralOfficeCode = this.RemainingNumber.Substring(0, 3);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
            this.CheckExcludedCOCs();
            this.CheckCOCLimit();
        }

        private void CheckCOCLimit()
        {
            if (Int32.Parse($"0{this.CentralOfficeCode}") < 100) this.AddError("CentralOfficeCode", "Too low");
        }

        private void CheckExcludedCOCs()
        {
            var excludedCOCs = new List<string>(new String[] { "411", "555", "911" });
            if (excludedCOCs.Contains(this.CentralOfficeCode)) this.AddError("CentralOfficeCode", "use of invalid central office code.");
        }

        internal void ParseExtraNumbers()
        {
            this.ExtraNumbers = String.Empty;
        }

        internal void ParseSubscriberNumber()
        {
            this.SubscriberNumber = this.RemainingNumber.Substring(0, 4);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
        }

        /*
        // TODO: Implement USPhoneNumber.CentralOfficeCode property
        public string CentralOfficeCode { get => throw new NotImplementedException(); }

        // TODO: Implement USPhoneNumber.SubscriberNumber property
        public string SubscriberNumber { get => throw new NotImplementedException(); }

        // TODO: Implement USPhoneNumber.SubscriberNumber property
        public string ExtraNumbers { get => throw new NotImplementedException(); }
        */

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
            this.AreaCode = this.RemainingNumber.Substring(0, 3);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
            if (Int32.Parse($"0{this.AreaCode}") < 100) this.AddError("AreaCode", "Too low");
        }
   }
}