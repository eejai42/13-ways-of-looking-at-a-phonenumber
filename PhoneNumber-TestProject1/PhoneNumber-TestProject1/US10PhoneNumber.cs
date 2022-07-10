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
            }
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