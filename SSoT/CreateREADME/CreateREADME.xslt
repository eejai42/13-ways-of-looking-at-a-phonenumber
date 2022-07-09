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
                        <xsl:text>../../README.md</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve"># Phone Number Challenge
This Repository includes a series of unit tests that are failing.  Your job is to finish the code
that has been started, following the patterns established, to make the unit tests pass.

The task at hand is to parse/validate phone number input:

### Phone Numbers

Each country has it's own phone numbers, and standards.  This project expects parsers to be created
for phone numbers from the following countries:

<xsl:for-each select="/*/Countries/Country">
 - <xsl:value-of select="Name" /></xsl:for-each>

The specific details/format from each country will be listed below:

<xsl:for-each select="/*/Countries/Country">
# <xsl:value-of select="Name" />
<xsl:apply-templates select="." />
</xsl:for-each>
                        
</xsl:element>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
<xsl:template match="/*/Countries/Country">
<xsl:value-of select="Name" /> has <xsl:value-of select="count(CountrySections/CountrySection)" /> possible sections in it's phone number.

    <xsl:for-each select="CountrySections/CountrySection">
    - <xsl:value-of select="Name" /></xsl:for-each>
</xsl:template>
</xsl:stylesheet>
