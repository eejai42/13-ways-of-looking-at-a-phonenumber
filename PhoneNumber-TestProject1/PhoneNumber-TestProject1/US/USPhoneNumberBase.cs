using System;

namespace PhoneNumber_TestProject1
{
    public abstract partial class USPhoneNumberBase : PhoneNumberBase
    {
        /// <summary>
        /// The length of the expected phone number
        /// </summary>
        public int ExpectedLength { get; }

        //public string AreaCode { get; set; }

        //// TODO: Implement USPhoneNumber.CentralOfficeCode property
        //public string CentralOfficeCode { get => throw new NotImplementedException(); }

        //// TODO: Implement USPhoneNumber.SubscriberNumber property
        //public string SubscriberNumber { get => throw new NotImplementedException(); }

        //// TODO: Implement USPhoneNumber.SubscriberNumber property
        //public string ExtraNumbers { get => throw new NotImplementedException(); }

        /// <summary>
        /// updated the US Phone Number
        /// </summary>
        /// <param name="e164Format"></param>
        /// <param name="expectedLength"></param>
        protected USPhoneNumberBase(string e164Format, int expectedLength) : base("US", e164Format)
        {
            this.ExpectedLength = expectedLength;
        }
    }
}