using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract class UKPhoneNumberBase : PhoneNumberBase
    {

        public int ExpectedLength { get; }
        public string CountryCode { get; set; }
        // TODO: Create the rest of the UK Phone number sections properties
        public object AreaCode { get => throw new NotImplementedException(); }
        public object CentralOfficeCode { get => throw new NotImplementedException(); }
        public object SubscriberNumber { get => throw new NotImplementedException(); }


        public UKPhoneNumberBase(string e164Format, int expectedLength) : base("UK", e164Format)
        {
            this.ExpectedLength = expectedLength;
        }
    }
}