using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct__Class
{
    // Struct is a value type
    // Stored in the stack
    // Inherited from object
    // Members of a struct are private by default

    struct PointStruct
    {
        public int x;
        public int y;
        // Below is a compilation error, because this struct/class does not participate in inheritance
            // hence, there is no point in a protected member
        // protected int z; // Error

        // An automatic default constructor is always written, even when we have a parameter constructor
        public PointStruct(int x, int y) { this.y = y; this.x = x; }

        // Destructors will be explained in the Garbage Collection notes
    }
}
