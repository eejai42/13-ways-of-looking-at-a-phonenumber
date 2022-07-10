# Phone Number Challenge
This Repository includes a series of unit tests that are failing.  Your job is to finish the code
that has been started, following the patterns established, to make the unit tests pass.

The task at hand is to parse/validate phone number input:

### Phone Numbers

Each country has it's own phone numbers, and standards.  This project expects parsers to be created
for phone numbers from the following countries:


 - UK
 - Germany
 - Canada
 - US

The specific details/format from each country will be listed below:


# UK
UK has 4 possible sections in it's phone number.

    
    - UK-CountryCode-##MIN-MAX
    - UK-AreaCode-###..###HAS AREA CODES
    - UK-CentralOfficeCode-#..###MIN-MAX
    - UK-SubscriberNumber-####..#MIN-MAX

# Germany
Germany has 3 possible sections in it's phone number.

    
    - Germany-CountryCode-##MIN-MAX
    - Germany-AreaCode-##..##MIN-MAX
    - Germany-SubscriberNumber-#####..###MIN-MAX

# Canada
Canada has 5 possible sections in it's phone number.

    
    - Canada-CountryCode-#MIN-MAX
    - Canada-AreaCode-###HAS AREA CODES
    - Canada-CentralOfficeCode-###MIN-MAX
    - Canada-SubscriberNumber-####MIN-MAX
    - Canada-ExtraNumbers-IGNOREDMIN-MAX

# US
US has 5 possible sections in it's phone number.

    
    - US-CountryCode-#MIN-MAX
    - US-AreaCode-###MIN-MAX
    - US-CentralOfficeCode-###HAS AREA CODES
    - US-SubscriberNumber-####MIN-MAX
    - US-ExtraNumbers-IGNOREDMIN-MAX

                        
