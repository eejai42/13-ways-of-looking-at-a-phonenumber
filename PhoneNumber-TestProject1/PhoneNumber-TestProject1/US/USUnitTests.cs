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
        /// Assertion is expected to fail because the value (411) is explicity excluded.
        /// </summary>

        [Test]
        public void US10PhoneNumberTest14144111234()
        {
            var parsedNumber = new US10PhoneNumber("+14144111234");

            // Check that each of the parts was found/interpreted correctly

            if (parsedNumber.IsValid)
            {
                Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
                Assert.IsTrue($"{parsedNumber.AreaCode}" == "414", $"AreaCode {parsedNumber.AreaCode} not 414 as expected.");
                Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "411", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 411 as expected.");
                Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1234", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1234 as expected.");
                Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");
            }


            Console.WriteLine("Assertion is expected to fail because the value (411) is explicity excluded.");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"US Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");

        }

        /// <summary>
        /// Assertion is expected to fail because the value (123) is to short
        /// </summary>

        [Test]
        public void US10PhoneNumberTest123()
        {
            var parsedNumber = new US10PhoneNumber("+123");

            // Check that each of the parts was found/interpreted correctly

            if (parsedNumber.IsValid)
            {
                Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
                Assert.IsTrue($"{parsedNumber.AreaCode}" == "", $"AreaCode {parsedNumber.AreaCode} not  as expected.");
                Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not  as expected.");
                Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "123", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 123 as expected.");
                Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");
            }


            Console.WriteLine("Assertion is expected to fail because the value (123) is to short");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"US Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");

        }

        /// <summary>
        /// Assertion is expected to fail because the value (555) is explicity excluded.
        /// </summary>

        [Test]
        public void US10PhoneNumberTest2125552134454412323()
        {
            var parsedNumber = new US10PhoneNumber("+2125552134454412323");

            // Check that each of the parts was found/interpreted correctly

            Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
            Assert.IsTrue($"{parsedNumber.AreaCode}" == "212", $"AreaCode {parsedNumber.AreaCode} not 212 as expected.");
            Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "555", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 555 as expected.");
            Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "2134", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 2134 as expected.");
            Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");



            Console.WriteLine("Assertion is expected to fail because the value (555) is explicity excluded.");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"US Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");

        }

        /// <summary>
        /// Assertion is expected to fail because the value (030) is too low.
        /// </summary>

        [Test]
        public void US10PhoneNumberTest16080300000()
        {
            var parsedNumber = new US10PhoneNumber("+16080300000");

            // Check that each of the parts was found/interpreted correctly

            Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
            Assert.IsTrue($"{parsedNumber.AreaCode}" == "608", $"AreaCode {parsedNumber.AreaCode} not 608 as expected.");
            Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "030", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 030 as expected.");
            Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "0000", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 0000 as expected.");
            Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");



            Console.WriteLine("Assertion is expected to fail because the value (030) is too low.");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"US Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");

        }

        /// <summary>
        /// Assertion is expected to fail because the value (911) is explicity excluded.
        /// </summary>

        [Test]
        public void US10PhoneNumberTest16089111234()
        {
            var parsedNumber = new US10PhoneNumber("+16089111234");

            // Check that each of the parts was found/interpreted correctly

            Assert.IsTrue($"{parsedNumber.CountryCode}" == "1", $"CountryCode {parsedNumber.CountryCode} not 1 as expected.");
            Assert.IsTrue($"{parsedNumber.AreaCode}" == "608", $"AreaCode {parsedNumber.AreaCode} not 608 as expected.");
            Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "911", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 911 as expected.");
            Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1234", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1234 as expected.");
            Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");



            Console.WriteLine("Assertion is expected to fail because the value (911) is explicity excluded.");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"US Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");

        }

        /// <summary>
        /// 
        /// </summary>

        [Test]
        public void US7PhoneNumberTest2781234()
        {
            var parsedNumber = new US7PhoneNumber("+2781234");

            // Check that each of the parts was found/interpreted correctly

            Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "278", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 278 as expected.");
            Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1234", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1234 as expected.");
            Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");



            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsTrue(parsedNumber.IsValid, "Phone number was expected to be successfully parsed.");

        }

        /// <summary>
        /// Assertion is expected to fail because the value (911) is explicity excluded.
        /// </summary>

        [Test]
        public void US7PhoneNumberTest911123488()
        {
            var parsedNumber = new US7PhoneNumber("+911123488");

            // Check that each of the parts was found/interpreted correctly

            Assert.IsTrue($"{parsedNumber.CentralOfficeCode}" == "911", $"CentralOfficeCode {parsedNumber.CentralOfficeCode} not 911 as expected.");
            Assert.IsTrue($"{parsedNumber.SubscriberNumber}" == "1234", $"SubscriberNumber {parsedNumber.SubscriberNumber} not 1234 as expected.");
            Assert.IsTrue($"{parsedNumber.ExtraNumbers}" == "", $"ExtraNumbers {parsedNumber.ExtraNumbers} not  as expected.");



            Console.WriteLine("Assertion is expected to fail because the value (911) is explicity excluded.");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"US Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");

        }

    }
}
