using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract class UKPhoneNumberBase : PhoneNumberBase
    {
        // TODO: Create the rest of the UK Phone number sections properties
        public string CountryCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ParseCountryCode()
        {
            if (this.RemainingNumber.StartsWith("44"))
            {
                this.CountryCode = "44";
                this.RemainingNumber = this.RemainingNumber.Substring(1);
            }
        }

        public UKPhoneNumberBase(string e164Format, int expectedLength) : base("UK", e164Format, expectedLength)
        {
        }
    }
}