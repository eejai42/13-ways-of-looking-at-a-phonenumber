using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract partial class UKPhoneNumberBase : PhoneNumberBase
    {
        // TODO: Create the rest of the UK Phone number sections properties

        public UKPhoneNumberBase(string e164Format, int expectedLength) : base("UK", e164Format, expectedLength)
        {
        }
    }
}