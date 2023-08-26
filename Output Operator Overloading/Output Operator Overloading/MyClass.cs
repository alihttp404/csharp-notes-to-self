using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output_Operator_Overloading
{
    internal class MyClass
    {
        public string? _name { get; private set; }

        public MyClass()
        {
            _name = null;
            Console.WriteLine("defualt constructor");
        }

        public MyClass(string name)
        {
            _name = name;
        }

        public override string ToString() // from base class "object"
        {
            return $"Object name: {_name}";
        }
    }
}
