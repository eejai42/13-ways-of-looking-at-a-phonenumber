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

    
    - UK-CountryCode-##
    - UK-AreaCode-###..##
    - UK-CentralOfficeCode-#..###
    - UK-SubscriberNumber-####..#

# Germany
Germany has 3 possible sections in it's phone number.

    
    - Germany-CountryCode-##
    - Germany-AreaCode-##..##
    - Germany-SubscriberNumber-#####..###

# Canada
Canada has 5 possible sections in it's phone number.

    
    - Canada-CountryCode-#
    - Canada-AreaCode-###
    - Canada-CentralOfficeCode-###
    - Canada-SubscriberNumber-####
    - Canada-ExtraNumbers-IGNORED

# US
US has 5 possible sections in it's phone number.

    
    - US-CountryCode-#
    - US-AreaCode-###
    - US-CentralOfficeCode-###
    - US-SubscriberNumber-####
    - US-ExtraNumbers-IGNORED

                        
