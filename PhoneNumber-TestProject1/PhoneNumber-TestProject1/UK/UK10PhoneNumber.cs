using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class UK10PhoneNumber : UKPhoneNumberBase
    {
        public UK10PhoneNumber(string e164Format) : base(e164Format, 10)
        {

        }

        public override void ParsePhoneNumber()
        {
            base.StripPlus();
            this.ParseCountryCode();
            // TODO: Write the rest of the UK phone number parsing method
        }

        private void ParseCountryCode()
        {
            if (this.RemainingNumber.StartsWith("44"))
            {
                this.CountryCode = "44";
                this.RemainingNumber = this.RemainingNumber.Substring(1);
            }
        }

        // TODO: Implement the rest of the UK 10 parsing logic
    }
}