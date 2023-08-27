using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_and_Types_Conversion
{
    internal class Type_Safety
    {
        // Type Safety
        /* C# is a type safe language, which means it doesn't allow for types to go off limits
         * Otherwise, it throws a compile time error */

        // int num = int.MaxValue + 1; // Compile time error

        // checked => if type safety is violated during runtime, a runtime error is thrown

        // below doesn't throw an error during compile time, because it's a runtime thing
        //checked
        //{
        //    int num = int.MaxValue;
        //    Console.WriteLine(num + 1);
        //}

        // above compiles, below doesn't
        //Console.WriteLine(num + 1);

        // so doesn't this:
        //checked
        //{
        //    int num = int.MaxValue + 1;
        //}
    }
}
