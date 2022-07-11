using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public abstract class CanadaPhoneNumberBase : PhoneNumberBase
    {

        public string CountryCode { get; set; }
        // TODO: Create the rest of the Canada Phone number sections properties
        public object AreaCode { get => throw new NotImplementedException(); }
        public object CentralOfficeCode { get => throw new NotImplementedException(); }
        public object SubscriberNumber { get => throw new NotImplementedException(); }
        public object ExtraNumbers { get => throw new NotImplementedException(); }

        public CanadaPhoneNumberBase(string e164Format, int expectedLength) : base("Canada", e164Format, expectedLength)
        {
        }
    }
}