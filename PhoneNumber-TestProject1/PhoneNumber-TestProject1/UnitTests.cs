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
        public void CanadaPhoneNumberTest14143561234()
        {
            var parsedNumber = new CanadaPhoneNumber("+14143561234");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid Canada Phone Number: {parsedNumber.E164Format}");
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
    
        [Test]
        public void USPhoneNumberTest14143561234()
        {
            var parsedNumber = new USPhoneNumber("+14143561234");
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
    
        [Test]
        public void CanadaPhoneNumberTest11250001348()
        {
            var parsedNumber = new CanadaPhoneNumber("+11250001348");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid Canada Phone Number: {parsedNumber.E164Format}");
            }
            else
            {
                
                Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
                Assert.IsTrue($"{parsedNumber.AreaCode}" == "125", $"AreaCode {parsedNumber.AreaCode} not 125 as expected.");
                Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "000", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 000 as expected.");
                Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1348", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1348 as expected.");
                Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");
            }
        }
    
        [Test]
        public void UKPhoneNumberTest12125551234()
        {
            var parsedNumber = new UKPhoneNumber("+12125551234");
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
    
        [Test]
        public void UKPhoneNumberTest4402081351234()
        {
            var parsedNumber = new UKPhoneNumber("+4402081351234");
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
    
        [Test]
        public void USPhoneNumberTest2125552134454412323()
        {
            var parsedNumber = new USPhoneNumber("+2125552134454412323");
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
