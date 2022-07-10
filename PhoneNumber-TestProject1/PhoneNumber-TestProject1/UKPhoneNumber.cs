using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class USPhoneNumber : PhoneNumberBase
    {

        public string CountryCode { get; set; }
        public string AfterCountryCode { get; set; }
        public string AreaCode { get; set; }
        public string AfterAreaCode { get; set; }
        public string CentralOfficeCode { get; set; }
        public string AfterCentralOfficeCode { get; set; }
        public string SubscriberNumber { get; set; }
        public string AfterSubscriberNumber { get; set; }

        public USPhoneNumber(string e164Format) : base(e164Format)
        {
            
        }

        protected override void ParsePhoneNumber()
        {
            base.StripPlus();
            this.ParseCountryCode();
            this.ParseAreaCode();
            // .. parse the rest of the number
        }

        private void ParseCountryCode()
        {
            if (this.RemainingNumber.StartsWith("1"))
            {
                this.CountryCode = "1";
                this.RemainingNumber = this.RemainingNumber.Substring(1);
            }
        }

        private void ParseAreaCode()
        {
            if (this.RemainingNumber.Length >= 10)
            {
                this.AreaCode = this.RemainingNumber.Substring(0, 3);
                this.RemainingNumber = this.RemainingNumber.Substring(3);
            }
        }

        // Implement the rest of the parsing logic
    }
}