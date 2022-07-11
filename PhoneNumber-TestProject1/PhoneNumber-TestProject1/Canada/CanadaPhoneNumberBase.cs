using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract class CanadaPhoneNumberBase : PhoneNumberBase
    {

        // TODO: Create the rest of the Canada Phone number sections properties

        public CanadaPhoneNumberBase(string e164Format, int expectedLength) : base("Canada", e164Format, expectedLength)
        {
        }

        internal void ParseCountryCode()
        {
            throw new NotImplementedException();
        }
    }
}