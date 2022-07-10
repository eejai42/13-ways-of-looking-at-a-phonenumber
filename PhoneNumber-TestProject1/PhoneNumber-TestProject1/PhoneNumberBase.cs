using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneNumber_TestProject1
{
    public abstract class PhoneNumberBase
    {
        public string E164Format { get; set; }
        public bool IsValid { get { return !this.Errors.Any(); } }
        public List<string> Errors { get; set; }
        public List<string> ErrorParts { get; }
        public string RemainingNumber { get; protected set; }

        public PhoneNumberBase(string e164Format)
        {
            this.E164Format = e164Format;
            this.Errors = new List<string>();
            this.ErrorParts = new List<string>();
            this.ParsePhoneNumber();
        }

        internal void AddError(string errorPart, string errorMessage)
        {
            this.ErrorParts.Add(errorPart);
            this.Errors.Add(errorMessage);
        }

        internal void StripPlus()
        {
            this.RemainingNumber = this.E164Format.Replace("+", "");
        }

        protected abstract void ParsePhoneNumber();
    }
}