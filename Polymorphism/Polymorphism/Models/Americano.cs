using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Americano : Car
    {
        public double KW { get; set; }

        public Americano() { }
        public Americano(string vendor, string model, DateTime date, double kw)
            : base(vendor, model, date) // base keyword is used to use a constructor from the base class
                                        // base can only refer to the parent class, no superclass 
        { KW = kw; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(KW);
        }
    }

    internal class AmericanoWithoutOverride : CarWithoutOverride
    {
        public double KW { get; set; }

        public AmericanoWithoutOverride() { }
        public AmericanoWithoutOverride(string vendor, string model, DateTime date, double kw)
            : base(vendor, model, date) // base keyword is used to use a constructor from the base class
                                        // base can only refer to the parent class, no superclass 
        { KW = kw; }

        public void Print()
        {
            Console.WriteLine("Vendor {0}", Vendor);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine(Date.ToString("MM/dd/yyyy"));
            Console.WriteLine(KW);
        }
    }
}
