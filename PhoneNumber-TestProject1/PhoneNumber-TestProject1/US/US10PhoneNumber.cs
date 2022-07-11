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
            base.ParseCountryCode();
            
            if (this.RemainingNumber.Length < this.ExpectedLength)
            {
                this.AddError("Length is to short.");
            } else
            {
                base.ParseAreaCode();
                base.ParseCentralOfficeCode();
                base.ParseSubscriberNumber();
                base.ParseExtraNumbers();
            }
        }   
    }
}