using NUnit.Framework;
using System;

namespace PhoneNumber_TestProject1
{
    public class UKUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// 
        /// </summary>

        [Test]
        public void UK10PhoneNumberTest4402081351234()
        {
            var parsedNumber = new UK10PhoneNumber("+4402081351234");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid UK Phone Number: {parsedNumber.E164Format}");
            }
            else
            {
                
                Assert.IsTrue($"{parsedNumber.CountryCode}" == "44", $"CountryCode {parsedNumber.CountryCode} not 44 as expected.");
                Assert.IsTrue($"{parsedNumber.AreaCode}" == "020", $"AreaCode {parsedNumber.AreaCode} not 020 as expected.");
                Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "8135", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 8135 as expected.");
                Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1234", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1234 as expected.");
            }
        }
    
        /// <summary>
        /// Assertion is expected to fail because the value (1) is too low.Assertion is expected to fail because the value (212) is missing from the list of allowed values.
        /// </summary>

        [Test]
        public void UK10PhoneNumberTest12125551234()
        {
            var parsedNumber = new UK10PhoneNumber("+12125551234");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid UK Phone Number: {parsedNumber.E164Format}");
            }
            else
            {
                
                Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
                Assert.IsTrue($"{parsedNumber.AreaCode}" == "212", $"AreaCode {parsedNumber.AreaCode} not 212 as expected.");
                Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "555", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 555 as expected.");
                Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1234", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1234 as expected.");
            }
        }
    
    }
}
