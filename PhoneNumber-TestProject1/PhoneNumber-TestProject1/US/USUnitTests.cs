using NUnit.Framework;
using System;

namespace PhoneNumber_TestProject1
{
    public class USUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// 
        /// </summary>

        [Test]
        public void US10PhoneNumberTest14143561234()
        {
            var parsedNumber = new US10PhoneNumber("+14143561234");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid US Phone Number: {parsedNumber.E164Format}");
            }
            else
            {
                
                Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
                Assert.IsTrue($"{parsedNumber.AreaCode}" == "414", $"AreaCode {parsedNumber.AreaCode} not 414 as expected.");
                Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "356", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 356 as expected.");
                Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1234", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1234 as expected.");
                Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");
            }
        }
    
        /// <summary>
        /// Assertion is expected to fail because the value (555) is explicity excluded.
        /// </summary>

        [Test]
        public void US10PhoneNumberTest2125552134454412323()
        {
            var parsedNumber = new US10PhoneNumber("+2125552134454412323");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid US Phone Number: {parsedNumber.E164Format}");
            }
            else
            {
                
                Assert.IsTrue($"{parsedNumber.CountryCode}" == "", $"CountryCode {parsedNumber.CountryCode} not  as expected.");
                Assert.IsTrue($"{parsedNumber.AreaCode}" == "212", $"AreaCode {parsedNumber.AreaCode} not 212 as expected.");
                Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "555", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 555 as expected.");
                Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "2134", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 2134 as expected.");
                Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "4544-12323", $"ExtraNumbers {parsedNumber.ExtraNumbers} not 4544-12323 as expected.");
            }
        }
    
    }
}
