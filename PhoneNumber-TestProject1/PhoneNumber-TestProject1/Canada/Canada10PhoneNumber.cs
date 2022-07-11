using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class Canada10PhoneNumber : CanadaPhoneNumberBase
    {
        public Canada10PhoneNumber(string e164Format) : base(e164Format, 10)
        {

        }

        public object AreaCode { get => throw new NotImplementedException(); }
        public object CentralOfficeCode { get; internal set; }
        public object SubscriberNumber { get; internal set; }
        public object ExtraNumbers { get; internal set; }

        // TODO: Write the rest of the Canda 10 digit Phone number parsing method
        protected override void ParsePhoneNumber()
        {
            base.StripPlus();
            // TODO: Write Canada  digit Phone Section parsing methods
            // this.ParseCountryCode();
        }

        private void ParseCountryCode()
        {
            if (this.RemainingNumber.StartsWith("1"))
            {
                this.CountryCode = "1";
                this.RemainingNumber = this.RemainingNumber.Substring(1);
            }
        }

        // Implement the rest of the parsing logic
    }
}