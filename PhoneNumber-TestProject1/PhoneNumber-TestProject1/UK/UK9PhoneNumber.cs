using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public partial class UK9PhoneNumber : UKPhoneNumberBase
    {
        public UK9PhoneNumber(string e164Format) : base(e164Format, 10)
        {

        }

        // TODO: Write the rest of the UK 10 digit Phone number parsing method
        protected override void ParsePhoneNumber()
        {
            base.StripPlus();
            // TODO: Write UK 10 digit Phone Section parsing methods
            // this.ParseCountryCode();
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