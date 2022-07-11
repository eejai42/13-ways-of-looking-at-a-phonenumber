using NUnit.Framework;
using System;

namespace PhoneNumber_TestProject1
{
    public class CanadaUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Assertion is expected to fail because the value (325) is missing from the list of allowed values.Assertion is expected to fail because the value (000) is too low.
        /// </summary>

        [Test]
        public void Canada10PhoneNumberTest13250001348()
        {
            var parsedNumber = new Canada10PhoneNumber("+13250001348");

            // Check that each of the parts was found/interpreted correctly
            
            Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
            Assert.IsTrue($"{parsedNumber.AreaCode}" == "325", $"AreaCode {parsedNumber.AreaCode} not 325 as expected.");
            Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "000", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 000 as expected.");
            Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1348", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1348 as expected.");
            Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");

    
            
            Console.WriteLine("Assertion is expected to fail because the value (325) is missing from the list of allowed values.Assertion is expected to fail because the value (000) is too low.");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"Canada Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");
    
        }
    
        /// <summary>
        /// Assertion is expected to fail because the value (414) is missing from the list of allowed values.
        /// </summary>

        [Test]
        public void Canada10PhoneNumberTest14143561234()
        {
            var parsedNumber = new Canada10PhoneNumber("+14143561234");

            // Check that each of the parts was found/interpreted correctly
            
            Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
            Assert.IsTrue($"{parsedNumber.AreaCode}" == "414", $"AreaCode {parsedNumber.AreaCode} not 414 as expected.");
            Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "356", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 356 as expected.");
            Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1234", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1234 as expected.");
            Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");

    
            
            Console.WriteLine("Assertion is expected to fail because the value (414) is missing from the list of allowed values.");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"Canada Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");
    
        }
    
    }
}
