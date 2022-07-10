using NUnit.Framework;
using System;

namespace PhoneNumber_TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var parsedNumber = new USPhoneNumber("+12125551234");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid US Phone Number: {parsedNumber.E164Format}");
            }
            else
            {
                Assert.IsTrue(parsedNumber.CountryCode == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
                Assert.IsTrue(parsedNumber.AreaCode == "212", $"AreaCode {parsedNumber.AreaCode} not 212 as expected.");
                Assert.IsTrue(parsedNumber.CentralOfficeCode == "555", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 555 as expected.");
                Assert.IsTrue(parsedNumber.SubscriberNumber == "1234", $"Subscriber Number {parsedNumber.SubscriberNumber} not 1234 as expected.");
            }
        }

        [Test]
        public void Test2()
        {
            var parsedNumber = new UKPhoneNumber("+4402084931234");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid UK Phone Number: {parsedNumber.E164Format}");
            }
            else
            {
                Assert.IsTrue(parsedNumber.CountryCode == "44", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
                Assert.IsTrue(parsedNumber.AreaCode == "020", $"AreaCode {parsedNumber.AreaCode} not 212 as expected.");
                Assert.IsTrue(parsedNumber.CentralOfficeCode == "8493", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 555 as expected.");
                Assert.IsTrue(parsedNumber.SubscriberNumber == "1234", $"Subscriber Number {parsedNumber.SubscriberNumber} not 1234 as expected.");
            }
        }

    }
}