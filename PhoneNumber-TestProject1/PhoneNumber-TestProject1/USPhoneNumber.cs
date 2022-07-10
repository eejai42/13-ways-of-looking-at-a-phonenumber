using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class UKPhoneNumber : PhoneNumberBase
    {

        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string CentralOfficeCode { get; set; }
        public string SubscriberNumber { get; set; }

        public UKPhoneNumber(string e164Format) : base(e164Format)
        {
            
        }

        protected override void ParsePhoneNumber()
        {
            base.AddError("CountryCode", "ParsePhoneNumber() not implemented.  That's your job...");
        }
    }
}