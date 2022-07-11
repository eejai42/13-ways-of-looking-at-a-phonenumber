<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:param name="output-filename" select="'output.txt'" />

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="/*">
        <FileSet>
            <FileSetFiles>
                <xsl:for-each select="/*/Countries/Country"><xsl:variable name="country" select="." /><xsl:variable name="test-name"><xsl:value-of select="Name" />
                <xsl:text>UnitTests</xsl:text></xsl:variable>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../../PhoneNumber-TestProject1/PhoneNumber-TestProject1/</xsl:text>
                        <xsl:value-of select="$country/Name" />
                        <xsl:text>/</xsl:text>
                        <xsl:value-of select="$test-name" />
                        <xsl:text>.cs</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve">using NUnit.Framework;
using System;

namespace PhoneNumber_TestProject1
{
    public class <xsl:value-of select="$test-name" />
    {
        [SetUp]
        public void Setup()
        {
        }
<xsl:for-each select="UnitTests/UnitTest">
        /// &lt;summary>
        /// <xsl:choose><xsl:when test="normalize-space()=''">This test is expected to successfully parse the Phone Number</xsl:when>
            <xsl:otherwise><xsl:value-of select="ExpectedFailedAssertionDescriptions" /></xsl:otherwise></xsl:choose>
        /// &lt;/summary>

        [Test]
        public void <xsl:value-of select="CountryName" /><xsl:value-of select="FormatLength" />PhoneNumberTest<xsl:value-of select="substring(E164Format, 2, string-length(E164Format))" />()
        {
            var parsedNumber = new <xsl:value-of select="CountryName" /><xsl:value-of select="FormatLength" />PhoneNumber("<xsl:value-of select="E164Format" />");

            // Check that each of the parts was found/interpreted correctly
            if (parsedNumber.IsValid)
            {
                <xsl:for-each select="./Assertions/Assertion">
                Assert.IsTrue($"{parsedNumber.<xsl:value-of select="SectionName" />}" == "<xsl:value-of select="ExtractedValue" />", $"<xsl:value-of select="SectionName" /> {parsedNumber.<xsl:value-of select="SectionName" />} not '<xsl:value-of select="ExtractedValue" />' as expected.");</xsl:for-each>
            }
            <xsl:choose>
    <xsl:when test="normalize-space(ExpectedFailedAssertionCount) = '0'">
            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsTrue(parsedNumber.IsValid, "Phone number was expected to be successfully parsed.");        
    </xsl:when>
    <xsl:otherwise>
            Console.WriteLine("<xsl:value-of select="ExpectedFailedAssertionDescriptions" />");

            // List errors
            parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));

            Assert.IsFalse(parsedNumber.IsValid, $"<xsl:value-of select="CountryName" /> Phone Number: {parsedNumber.E164Format} did not FAIL to parse (as expected)");
    </xsl:otherwise>
        </xsl:choose>
        }
    </xsl:for-each>
    }
}
</xsl:element>
                </FileSetFile>
            </xsl:for-each>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
