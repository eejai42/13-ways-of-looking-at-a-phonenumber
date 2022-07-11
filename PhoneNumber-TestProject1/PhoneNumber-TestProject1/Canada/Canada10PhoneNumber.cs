using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class Canada10PhoneNumber : CanadaPhoneNumberBase
    {
        public Canada10PhoneNumber(string e164Format) : base(e164Format, 10)
        {

        }

        // TODO: Write the rest of the Canda 10 digit Phone number parsing method
        public override void ParsePhoneNumber()
        {
            base.StripPlus();
             this.ParseCountryCode();
            // TODO: Call the rest of the Canada digit Phone Section parsing methods
        }

        private void ParseCountryCode()
        {
            if (this.RemainingNumber.StartsWith("1"))
            {
                this.CountryCode = "1";
                this.RemainingNumber = this.RemainingNumber.Substring(1);
            }
        }

        // TODO: Write the rest of the Canada digit Phone Section parsing methods
    }
}