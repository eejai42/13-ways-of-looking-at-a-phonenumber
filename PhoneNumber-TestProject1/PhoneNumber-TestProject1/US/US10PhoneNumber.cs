using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class US10PhoneNumber : USPhoneNumberBase
    {
        public US10PhoneNumber(string e164Format) : base(e164Format, 10)
        {
        }

        /// <summary>
        /// Parses the 10 digit format for a US Phone Number
        /// </summary>
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
                // TODO: Call the rest of the parse methods
            }
        }

        private void ParseExtraNumbers()
        {
            this.RemainingNumber = this.ExtraNumbers = "";            
        }

        /// <summary>
        /// Check if the first code is a 1 - indicating that the countrycode was dialed
        /// </summary>
        private void ParseCountryCode()
        {
            this.CountryCode = "1";
            if (this.RemainingNumber.StartsWith("1"))
            {
                this.RemainingNumber = this.RemainingNumber.Substring(1);
            }
        }

        /// <summary>
        /// Check that the input number was the correct/expected length
        /// </summary>
        /// <returns>Returns true if the length is the expected length</returns>
        internal bool CheckLength()
        {
            if (this.RemainingNumber.Length < this.ExpectedLength)
            {
                this.AddError($"Input string {E164Format} not a valid {this.ExpectedLength} digit phone number.");
                return false;
            }
            else return true;
        }


        /// <summary>
        /// Strip the area ocde off of the number
        /// </summary>
        private void ParseAreaCode()
        {
            this.AreaCode = this.RemainingNumber.Substring(0, 3);
            this.RemainingNumber = this.RemainingNumber.Substring(3);
            if (Int32.Parse($"0{this.AreaCode}") < 100) this.AddError("AreaCode", "Too low");
        }

        // TODO: Implement the rest of the US10 PhoneNumber parsing logic
    }
}