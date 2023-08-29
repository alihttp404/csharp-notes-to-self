using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Tesla : Car
    {
        public double KW { get; set; }

        public Tesla() { }
        public Tesla(string vendor, string model, DateTime date, double kw)
            : base(vendor, model, date) // base keyword is used to use a constructor from the base class
                                        // base can only refer to the parent class, no superclass 
        { KW = kw; }
    }
}
