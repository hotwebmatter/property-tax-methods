# property-tax-methods

Tenth programming exercise in chapter three.

Write an application that helps landowners determine what their property
tax will be for the current year. Taxes are based on the property's
assessed value and the annual millage rate. The established millage rate
for the current year is $10.03 per $1000 value. Homeowners are given
a $25,000 exemption, which means they may subtract $25,000 from the
assessed value prior to calculating the taxes. Enable users to enter the
property address and the prior year's assessed value.The township has
decided to increase all properties' assessed value 2.7% for the current
year to add additional monies to the school budget line. Provide methods
to compute and return the new assessed value and the proposed taxes for
the current year. Provide another method that displays the formatted values.

## Example output
```
$ dotnet bin/Debug/netcoreapp2.1/property-tax-methods.dll
Enter property address: 123 Shady Lane
Enter assesed value: jkl;
Invalid input!
Enter assesed value: 250000

****** Property Tax Assessment Table ******
*     Property Address:    123 Shady Lane *
*       Assessed Value:       $250,000.00 *
* Value After Increase:       $256,750.00 *
*            Exemption:        $25,000.00 *
*        Taxable Value:       $231,750.00 *
*         Property Tax:         $2,324.45 *
*******************************************
```