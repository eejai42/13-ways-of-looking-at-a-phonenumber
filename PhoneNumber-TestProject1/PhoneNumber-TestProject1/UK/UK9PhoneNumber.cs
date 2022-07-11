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
        public override void ParsePhoneNumber()
        {
            base.StripPlus();
            // TODO: Call the rest of the UK 9 digit Phone Section parsing methods
            // base.ParseCountryCode();
        }

        // TODO: Write UK 9 digit Phone Section parsing methods
    }
}