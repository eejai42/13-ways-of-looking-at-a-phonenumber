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
                <xsl:for-each select="/*/Countries/Country[Name='US']"><xsl:variable name="country" /><xsl:variable name="phone-number-base">
                    <xsl:value-of select="Name" />
                    <xsl:text>PhoneNumberBase</xsl:text>
                </xsl:variable>
                <FileSetFile>
                    <RelativePath>
                        <xsl:value-of select="Name" />
                        <xsl:text>/</xsl:text>
                        <xsl:value-of select="$phone-number-base" />
                        <xsl:text>.designer.cs</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve">using System;

namespace PhoneNumber_TestProject1
{
    public abstract partial class <xsl:value-of select="$phone-number-base" /> : PhoneNumberBase
    {
        <xsl:for-each select="CountrySections/CountrySection[normalize-space(PhoneNumberSectionName) != '']">
        public string <xsl:value-of select="PhoneNumberSectionName" /> { get; set; }</xsl:for-each>
    }
}
</xsl:element>
                </FileSetFile>
                </xsl:for-each>                
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
