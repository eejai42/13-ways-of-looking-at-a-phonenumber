using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumber_TestProject1 
{
    public abstract partial class GermanyPhoneNumberBase : PhoneNumberBase
    {
        protected GermanyPhoneNumberBase(string countryName, string e164Format, int expectedLength)
            : base(countryName, e164Format, expectedLength)
        {
        }
    }
}
