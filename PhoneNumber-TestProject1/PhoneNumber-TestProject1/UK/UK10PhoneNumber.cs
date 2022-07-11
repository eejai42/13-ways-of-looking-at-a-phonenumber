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
            base.ParseCountryCode();
            // TODO: Write the rest of the UK phone number parsing method
        }

    }
}