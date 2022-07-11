using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class US10PhoneNumber : USPhoneNumberBase
    {
        public US10PhoneNumber(string e164Format) : base(e164Format, 10)
        {
        }

        /// <summary>
        /// Parses the 10 digit format for a US Phone Number
        /// </summary>
        public override void ParsePhoneNumber()
        {
            base.StripPlus();
            this.ParseCountryCode();
            if (this.CheckLength())
            {
                base.ParseAreaCode();
             
                // TODO: Call the rest of the parse methods
                //base.ParseCentralOfficeCode();
                //base.ParseSubscriberNumber();
                //base.ParseExtraNumbers();
            }
        }

        // TODO: Implement the rest of the US10 PhoneNumber parsing logic
    }
}