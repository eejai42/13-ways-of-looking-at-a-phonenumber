using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumber_TestProject1
{
    public abstract class PhoneNumberBase
    {
        /// <summary>
        /// The name of the country that this phone number is expected to be.  
        /// </summary>
        public string CountryName { get; }

        /// <summary>
        /// A standard E164 formatted version of the given phone number
        /// </summary>
        public string E164Format { get; set; }

        /// <summary>
        /// The length of the expected phone number
        /// </summary>
        public int ExpectedLength { get; }

        /// <summary>
        /// A boolean value indicating the current state of this object.  It will return false if there are no errors listed.
        /// </summary>
        public bool IsValid { get { return !this.Errors.Any() && !this.ErrorParts.Any(); } }


        /// <summary>
        /// A list of errors that have been detected, associated with this phone number
        /// </summary>
        public List<string> Errors { get; set; }

        /// <summary>
        /// a list of the specific sections of this number that have been found to be invalid.
        /// </summary>
        public List<string> ErrorParts { get; }


        /// <summary>
        /// RemainingNumber is an internal, volatile representation of the E164Format original phone number, and
        /// is expected to be used during the parsing process to keep track of the remaining portion of the number.
        /// </summary>
        public string RemainingNumber { get; protected set; }

        /// <summary>
        /// A constructor which sets all of the initial values, and then attempts to parse the number
        /// </summary>
        /// <param name="countryName"></param>
        /// <param name="e164Format"></param>
        public PhoneNumberBase(string countryName, string e164Format, int expectedLength)
        {
            this.ExpectedLength = expectedLength;
            this.CountryName = countryName;
            this.E164Format = e164Format;
            this.Errors = new List<string>();
            this.ErrorParts = new List<string>();
            this.ParsePhoneNumber();
        }

        /// <summary>
        /// Each sub-class is expected to implement a ParsePhoneNumber method for that specific country.
        /// </summary>
        protected abstract void ParsePhoneNumber();


        /// <summary>
        /// Adds an error to this phone number - indiciating that is is invalid in some way
        /// </summary>
        /// <param name="errorMessage"></param>
        internal void AddError(string errorMessage)
        {
            this.AddError(string.Empty, errorMessage);
        }

        /// <summary>
        /// Adds an error (along with the part of the phone number that is invalid)
        /// indicating that the entire number is invalid in some way
        /// </summary>
        /// <param name="errorPart">The part/section of the phone number which is invalid (such as Area Code)</param>
        /// <param name="errorMessage">The specific error that was encountered while attempting to parse the phone number.</param>
        internal void AddError(string errorPart, string errorMessage)
        {
            Console.WriteLine($"ERROR: {errorPart}::{errorMessage}");
            if (!String.IsNullOrEmpty(errorPart)) this.ErrorParts.Add(errorPart);
            this.Errors.Add(errorMessage);
        }

        /// <summary>
        /// An internal method which can be used to strip off the initial + if it is present (as expected by the E164 format).
        /// </summary>
        internal void StripPlus()
        {
            this.RemainingNumber = this.E164Format.Replace("+", "");
        }

    }
}