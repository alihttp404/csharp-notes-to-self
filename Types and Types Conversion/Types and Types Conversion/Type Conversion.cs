using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_and_Types_Conversion
{
    internal class Type_Conversion
    {
        // 1. Explicit
        // Both upcasting and downcasting are legal
        // There are 3 ways to explicitly typecast in C#

        // WAY #1 - Parse() and TryParse()
        // Each data type has a method called Parse() and TryParse(), which typecasts a string into the data type which it was called in
        // Parse() throws an error if it can't turn the string into that data type
        // TryParse() returns a bool based on if it can typecast it or not

        // Usage: [type] variable_name = [type].Parse("[string to convert]");
        // Usage same for TryParse()

        // Example:
        // int num = int.Parse("125");

        // Useful for inputting data, since Console.ReadLine() returns a string


        // WAY #2 - Convert
        // Convert is a class with methods to typecast each data type into another
        // If it can't convert, it throws an error

        // Usage: [destination_type] variable_name = Convert.To[type to convert to/destination_type]([data]);

        // Examples:
        // float num = Convert.ToSingle("15.36");
        // string symbol = Convert.ToString(15);


        // WAY #3 - the basic way
        // Converts anything to anything
        // If it can't convert, it throws an error

        // Usage: ([type_to_convert_to])[data]

        // Example:
        // (int)15.35


        // 2. Implicit
        // Only upcasting is allowed

        // double num = 15 // ok
        // int num = 15.35 // error
    }
}
