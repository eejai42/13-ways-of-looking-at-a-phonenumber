using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class US10PhoneNumber : USPhoneNumberBase
    {
        public US10PhoneNumber(string e164Format) : base(e164Format, 10)
        {
            
        }

        protected override void ParsePhoneNumber()
        {
            base.StripPlus();
            this.ParseCountryCode();
            if (this.CheckLength())
            {
                this.ParseAreaCode();
                this.ParseCentralOfficeCode();
                this.ParseSubscriberNumber();
                this.ParseExtraNumbers();
            }
        }

        private void ParseExtraNumbers()
        {
            this.ExtraNumbers = "";
            this.RemainingNumber = "";
        }

        private void ParseCentralOfficeCode()
        {
            this.CentralOfficeCode = this.RemainingNumber.Substring(0, 3);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
            if (Int32.Parse(this.CentralOfficeCode) < 100) this.AddError("CentralOfficeCode", "Too low!");
            if (Int32.Parse(this.CentralOfficeCode) == 555) this.AddError("CentralOfficeCode", "555 is now allowed!");
            if (Int32.Parse(this.CentralOfficeCode) == 911) this.AddError("CentralOfficeCode", "911 is now allowed!");
        }

        private void ParseSubscriberNumber()
        {
            this.SubscriberNumber = this.RemainingNumber.Substring(0, 4);
            this.RemainingNumber = this.RemainingNumber.Substring(4);
        }

        private void ParseCountryCode()
        {
            if (this.RemainingNumber.StartsWith("1"))
            {
                this.CountryCode = "1";
                this.RemainingNumber = this.RemainingNumber.Substring(1);
            }
        }

        internal bool CheckLength()
        {
            if (this.RemainingNumber.Length < this.ExpectedLength)
            {
                this.AddError($"Input string {E164Format} not a valid {this.ExpectedLength} digit phone number.");
                return false;
            }
            else return true;
        }

        private void ParseAreaCode()
        {
            this.AreaCode = this.RemainingNumber.Substring(0, 3);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
        }

        // Implement the rest of the parsing logic
    }
}