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
    <xsl:template match="/*/UnitTests/UnitTest">
        <CountryName><xsl:value-of select="CountryName" /></CountryName>
        <CountryCode><xsl:value-of select="CountryCode" /></CountryCode>
        <CountryFormat><xsl:value-of select="CountryFormat" /></CountryFormat>
        <FormatLength><xsl:value-of select="FormatLength" /></FormatLength>
        <PhoneNumber><xsl:value-of select="PhoneNumber" /></PhoneNumber>
        <E164Format><xsl:value-of select="E164Format" /></E164Format>
        <ExpectedFailedAssertionCount><xsl:value-of select="ExpectedFailedAssertionCount" /></ExpectedFailedAssertionCount>
        <ExpectedFailedAssertions><xsl:value-of select="ExpectedFailedAssertions" /></ExpectedFailedAssertions>
        <ExpectedFailedAssertionDescriptions><xsl:value-of select="ExpectedFailedAssertionDescriptions" /></ExpectedFailedAssertionDescriptions>
        <xsl:for-each select="*[substring(name(), 1, 7) = 'Section' and string-length(name()) = 8]"><xsl:sort select="name()" />
        &lt;<xsl:value-of select="name()" />><xsl:value-of select="." />&lt;/<xsl:value-of select="name()" />></xsl:for-each>
        <Assertions>
            <xsl:for-each select="/*/Assertions/Assertion[UnitTestName=current()/Name]"><xsl:sort select="SectionOrder" />
                <xsl:copy>
                    <xsl:apply-templates select="." />
                </xsl:copy>                    
            </xsl:for-each>
        </Assertions>
    </xsl:template>

    <xsl:template match="/*/Assertions/Assertion">
        <Name><xsl:value-of select="Name" /></Name>
        <CountryName><xsl:value-of select="CountryName" /></CountryName>
        <UnitTestName><xsl:value-of select="UnitTestName" /></UnitTestName>
        <TestValue><xsl:value-of select="TestValue" /></TestValue>
        <SectionName><xsl:value-of select="SectionName" /></SectionName>
        <FailureDescription><xsl:value-of select="FailureDescription" /></FailureDescription>
        <ExtractedValue><xsl:value-of select="ExtractedValue" /></ExtractedValue>
        <AssertionFailed><xsl:value-of select="AssertionFailed" /></AssertionFailed>
        <ParameterMin><xsl:value-of select="ParameterMin" /></ParameterMin>
        <ParameterMax><xsl:value-of select="ParameterMax" /></ParameterMax>
        <SectionMinlength><xsl:value-of select="SectionMinlength" /></SectionMinlength>
        <SectionMaxLength><xsl:value-of select="SectionMaxLength" /></SectionMaxLength>
        <TooLow><xsl:value-of select="TooLow" /></TooLow>
        <TooHigh><xsl:value-of select="TooHigh" /></TooHigh>
        <MissingFromAllowedSectionValues><xsl:value-of select="MissingFromAllowedSectionValues" /></MissingFromAllowedSectionValues>
        <FoundInDisallowedSectionValues><xsl:value-of select="FoundInDisallowedSectionValues" /></FoundInDisallowedSectionValues>
        <Section1><xsl:value-of select="Section1" /></Section1>
        <Section2><xsl:value-of select="Section2" /></Section2>
        <Section3><xsl:value-of select="Section3" /></Section3>
        <Section4><xsl:value-of select="Section4" /></Section4>
        <Section5><xsl:value-of select="Section5" /></Section5>
        <AllowedSectionValues><xsl:value-of select="AllowedSectionValues" /></AllowedSectionValues>
        <DisallowedSectionValues><xsl:value-of select="DisallowedSectionValues" /></DisallowedSectionValues>
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
        <CountryFormats>
            <xsl:for-each select="/*/CountryFormats/CountryFormat[Country=current()/CountryId]"><xsl:sort select="FormatLength" order="descending" />
                <xsl:copy>
                    <xsl:apply-templates select="." />
                </xsl:copy>
            </xsl:for-each>
        </CountryFormats>
        <UnitTests>
            <xsl:for-each select="$root/*/UnitTests/UnitTest[CountryName=current()/Name]"><xsl:sort select="Name" />
                <xsl:copy>
                    <xsl:apply-templates select="." />
                </xsl:copy>    
            </xsl:for-each>
        </UnitTests>
    
    </xsl:template>

    <xsl:template match="/*/CountryFormats/CountryFormat">
        <Name><xsl:value-of select="Name" /></Name>
        <Format><xsl:value-of select="Format" /></Format>
        <FormatLength><xsl:value-of select="FormatLength" /></FormatLength>
    </xsl:template>

    <xsl:template match="/*/PhoneNumberSections/PhoneNumberSection">
        <Name><xsl:value-of select="Name" /></Name>
        <Notes><xsl:value-of select="Notes" /></Notes>
        <SectionOrder><xsl:value-of select="SectionOrder" /></SectionOrder>
    </xsl:template>

    <xsl:template match="/*/CountrySections/CountrySection">
        <Name><xsl:value-of select="Name" /></Name>
        <xsl:choose>
            <xsl:when test="normalize-space(IsIgnored)='true'">
                <IsIgnored>true</IsIgnored>
                <IsRequired>false</IsRequired>
            </xsl:when>
            <xsl:otherwise>
                <PhoneNumberSectionName><xsl:value-of select="PhoneNumberSectionName" /></PhoneNumberSectionName>
                <CountryName><xsl:value-of select="CountryName" /></CountryName>
                <CountryCode><xsl:value-of select="CountryCode" /></CountryCode>        
                <IsRequired>
                    <xsl:choose>
                        <xsl:when test="normalize-space(IsRequired)=''">false</xsl:when>
                        <xsl:otherwise>
                            <xsl:value-of select="IsRequired" />
                        </xsl:otherwise>
                    </xsl:choose>
                </IsRequired>
                <MinValue><xsl:value-of select="MinValueString" /></MinValue>
                <MaxValue><xsl:value-of select="MaxValue" /></MaxValue>
                <MinLength><xsl:value-of select="MinLength" /></MinLength>
                <MaxLength><xsl:value-of select="MaxLength" /></MaxLength>
            </xsl:otherwise>
        </xsl:choose>
        <SectionValues>
            <xsl:for-each select="/*/SpecialSectionValues/SpecialSectionValue[CountryName=current()/CountryName and PhoneNumberSectionName=current()/PhoneNumberSectionName]"><xsl:sort select="SpecialName" /><xsl:sort select="Value" />
            <xsl:apply-templates select="." />
        </xsl:for-each>
        </SectionValues>
    </xsl:template>

    <xsl:template match="/*/SpecialSectionValues/SpecialSectionValue">
        <SectionValue>
            <Name><xsl:value-of select="SpecialName" /></Name>
            <Value><xsl:value-of select="Value" /></Value>          
            <FollowingFormat><xsl:value-of select="FollowingFormat" /></FollowingFormat>          
            <COCTypeName><xsl:value-of select="COCTypeName" /></COCTypeName>          
            <SubscriberNumberMinLength><xsl:value-of select="SubscriberNumberMinLength" /></SubscriberNumberMinLength>          
            <SubscriberNumberMaxLength><xsl:value-of select="SubscriberNumberMaxLength" /></SubscriberNumberMaxLength>          
        </SectionValue>
</xsl:template>
</xsl:stylesheet>
