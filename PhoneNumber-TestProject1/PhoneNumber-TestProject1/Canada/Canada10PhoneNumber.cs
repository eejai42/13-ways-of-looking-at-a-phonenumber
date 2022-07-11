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
            // TODO: Call the rest of the Canada digit Phone Section parsing methods
            //base.ParseCountryCode();
            //base.ParseAreaCode();
            //base.ParseCentralOfficeCode();
            //base.ParseSubscriberNumber();
        }
    }
}