using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class US7PhoneNumber : USPhoneNumberBase
    {
        public US7PhoneNumber(string e164Format) : base(e164Format, 7)
        {

        }

        public override void ParsePhoneNumber()
        {
            base.StripPlus();
            // TODO: Write US 7 digit Phone Section parsing methods
            //this.ParseCentralOfficeCode();
            //this.ParseSubscriberNumber();
        }

        // Implement the rest of the parsing logic
    }
}