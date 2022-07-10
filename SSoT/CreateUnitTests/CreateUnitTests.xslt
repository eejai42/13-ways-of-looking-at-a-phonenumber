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
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>../../PhoneNumber-TestProject1/PhoneNumber-TestProject1/UnitTests.cs</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve">using NUnit.Framework;
using System;

namespace PhoneNumber_TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
<xsl:for-each select="/*/UnitTests/UnitTest">
        [Test]
        public void <xsl:value-of select="CountryName" />PhoneNumberTest<xsl:value-of select="substring(E164Format, 2, string-length(E164Format))" />()
        {
            var parsedNumber = new <xsl:value-of select="CountryName" />PhoneNumber("<xsl:value-of select="E164Format" />");
            if (!parsedNumber.IsValid)
            {
                parsedNumber.Errors.ForEach(err => Console.WriteLine($"{err}"));
                Assert.Fail($"Invalid <xsl:value-of select="CountryName" /> Phone Number: {parsedNumber.E164Format}");
            }
            else
            {
                <xsl:for-each select="./Assertions/Assertion">
                Assert.IsTrue(parsedNumber.<xsl:value-of select="SectionName" /> == "<xsl:value-of select="ExtractedValue" />", $"<xsl:value-of select="SectionName" /> {parsedNumber.<xsl:value-of select="SectionName" />} not <xsl:value-of select="ExtractedValue" /> as expected.");</xsl:for-each>
            }
        }
    </xsl:for-each>
    }
}
</xsl:element>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
