using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract partial class USPhoneNumberBase : PhoneNumberBase
    {
        protected USPhoneNumberBase(string e164Format, int expectedLength)
            : base("US", e164Format, expectedLength)
        {
        }
    }
}