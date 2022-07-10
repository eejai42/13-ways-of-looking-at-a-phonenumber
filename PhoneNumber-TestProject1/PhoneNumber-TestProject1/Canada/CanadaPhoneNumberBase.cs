using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class CanadaPhoneNumberBase : PhoneNumberBase
    {
        //public string CountryCode { get; set; }
        //public string AreaCode { get; set; }
        //public string CentralOfficeCode { get; set; }
        //public string SubscriberNumber { get; set; }

        public CanadaPhoneNumberBase(string e164Format) : base("Canada", e164Format)
        {

        }

        protected override void ParsePhoneNumber()
        {
            base.AddError("CountryCode", "ParsePhoneNumber() not implemented.  That's your job...");
        }

        // TO-DO: Implement the rest of the paring methods...
    }
}