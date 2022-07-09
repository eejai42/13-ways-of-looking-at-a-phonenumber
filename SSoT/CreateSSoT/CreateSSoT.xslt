<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:param name="output-filename" select="'output.txt'" />
    <xsl:variable name="root" select="/" />

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
                        <xsl:text>../TWOLAAPhoneNumber.xml</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve">
<TWOLAAPhoneNumber>
    <Name>13 Ways of Looking at a Phone Number</Name>
    <Countries>
        <xsl:for-each select="$root/*/Countries/Country">
        <xsl:copy>
            <xsl:apply-templates select="." />
        </xsl:copy>    
    </xsl:for-each>
    </Countries>
    <PhoneNumberSections>
        <xsl:for-each select="$root/*/PhoneNumberSections/PhoneNumberSection"><xsl:sort select="SectionOrder" />
            <xsl:copy>
                <xsl:apply-templates select="." />
            </xsl:copy>    
        </xsl:for-each>
    </PhoneNumberSections>
</TWOLAAPhoneNumber>                        
                    </xsl:element>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
    <xsl:template match="/*/Countries/Country">
        <Name><xsl:value-of select="Name" /></Name>
        <CountrySections>
            <xsl:for-each select="//CountrySections/CountrySection[Country=current()/CountryId]"><xsl:sort select="SectionOrder" />
                <xsl:copy>
                    <xsl:apply-templates select="." />
                </xsl:copy>             
            </xsl:for-each>
        </CountrySections>
    </xsl:template>

    <xsl:template match="/*/PhoneNumberSections/PhoneNumberSection">
        <Name><xsl:value-of select="Name" /></Name>
        <Notes><xsl:value-of select="Notes" /></Notes>
        <SectionOrder><xsl:value-of select="SectionOrder" /></SectionOrder>
    </xsl:template>

    <xsl:template match="/*/CountrySections/CountrySection">
        <Name><xsl:value-of select="Name" /></Name>
        <IsRequired><xsl:value-of select="IsRequired" /></IsRequired>
        <SectionOrder><xsl:value-of select="SectionOrder" /></SectionOrder>
        <MinValue><xsl:value-of select="MinValue" /></MinValue>
        <MinValueString><xsl:value-of select="MinValueString" /></MinValueString>
        <MaxValue><xsl:value-of select="MaxValue" /></MaxValue>
        <MinLength><xsl:value-of select="MinLength" /></MinLength>
        <MaxLength><xsl:value-of select="MaxLength" /></MaxLength>
        <MinAndMaxLengthsMatch><xsl:value-of select="MinAndMaxLengthsMatch" /></MinAndMaxLengthsMatch>
        <CountryCode><xsl:value-of select="CountryCode" /></CountryCode>
    </xsl:template>
</xsl:stylesheet>
