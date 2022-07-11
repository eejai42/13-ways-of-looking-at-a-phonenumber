using System;
using System.Collections.Generic;

namespace PhoneNumber_TestProject1
{
    public class US7PhoneNumber : USPhoneNumberBase
    {
        public US7PhoneNumber(string e164Format) : base(e164Format, 7)
        {

        }

        public override void ParsePhoneNumber()
        {
            base.StripPlus();
            if (this.CheckLength())
            {
                // TODO: Write US 7 digit Phone Section parsing methods
                //this.ParseCentralOfficeCode();
                //this.ParseSubscriberNumber();
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


        // Implement the rest of the parsing logic
    }
}