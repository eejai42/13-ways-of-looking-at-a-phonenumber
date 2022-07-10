using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class UK10PhoneNumber : USPhoneNumberBase
    {
        public UK10PhoneNumber(string e164Format) : base(e164Format, 10)
        {

        }

        protected override void ParsePhoneNumber()
        {
            base.StripPlus();
            this.ParseCountryCode();
        }

        private void ParseCountryCode()
        {
            if (this.RemainingNumber.StartsWith("44"))
            {
                this.CountryCode = "44";
                this.RemainingNumber = this.RemainingNumber.Substring(1);
            }
        }

        // Implement the rest of the parsing logic
    }
}