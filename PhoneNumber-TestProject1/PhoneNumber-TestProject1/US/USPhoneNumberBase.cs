using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract partial class USPhoneNumberBase : PhoneNumberBase
    {
        /// <summary>
        /// updated the US Phone Number
        /// </summary>
        /// <param name="e164Format"></param>
        /// <param name="expectedLength"></param>
        protected USPhoneNumberBase(string e164Format, int expectedLength) : base("US", e164Format, expectedLength)
        {
        }

        internal void ParseCountryCode()
        {
            throw new NotImplementedException();
        }

        internal void ParseAreaCode()
        {
            throw new NotImplementedException();
        }

        internal void ParseCentralOfficeCode()
        {
            throw new NotImplementedException();
        }

        internal void ParseExtraNumbers()
        {
            throw new NotImplementedException();
        }

        internal void ParseSubscriberNumber()
        {
            throw new NotImplementedException();
        }
    }
}