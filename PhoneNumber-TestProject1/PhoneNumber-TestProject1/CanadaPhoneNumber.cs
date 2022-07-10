using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class CanadaPhoneNumber : PhoneNumberBase
    {

        public string CountryCode { get; set; }
        public string AfterCountryCode { get; set; }
        public string AreaCode { get; set; }
        public string AfterAreaCode { get; set; }
        public string CentralOfficeCode { get; set; }
        public string AfterCentralOfficeCode { get; set; }
        public string SubscriberNumber { get; set; }
        public string AfterSubscriberNumber { get; set; }
        public string ExtraNumbers { get; internal set; }

        public CanadaPhoneNumber(string e164Format) : base(e164Format)
        {
            
        }

        protected override void ParsePhoneNumber()
        {
            base.StripPlus();
            this.ParseCountryCode();
            this.ParseAreaCode();
            this.ParseCentralOfficeCode();
            this.ParseSubscriberNumber();
            this.ParseExtraNumbers();
        }

        private void ParseExtraNumbers()
        {
            this.ExtraNumbers = this.RemainingNumber;
        }

        private void ParseSubscriberNumber()
        {
            this.SubscriberNumber = this.RemainingNumber.Substring(0, 4);
            this.RemainingNumber = this.RemainingNumber.Substring(4);
        }

        private void ParseCentralOfficeCode()
        {
            this.CentralOfficeCode = this.RemainingNumber.Substring(0, 3);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
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