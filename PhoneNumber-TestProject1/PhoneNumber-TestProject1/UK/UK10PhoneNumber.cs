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
            // TODO: Parse the rest of the fields in this number
            //this.ParseAreaCode();
            //this.ParseCentralOfficeCode();
            //this.ParseSubscriberNumber();
        }

    }
}