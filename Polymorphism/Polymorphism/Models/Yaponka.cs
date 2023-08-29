using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Yaponka : Car
    {
        bool IsRightHandDrive { get; set; }

        public Yaponka() { }
        public Yaponka(string vendor, string model, DateTime date, bool isRightHandDrive)
            : base(vendor, model, date) // base keyword is used to use a constructor from the base class
                                        // base can only refer to the parent class, no superclass 
        { IsRightHandDrive = isRightHandDrive; }

        public virtual void Print()
        {
            base.Print();
            Console.WriteLine((IsRightHandDrive) ? "Right hand drive" : "Left hand drive");
        }
    }

    internal class YaponkaWithoutOverride : CarWithoutOverride
    {
        bool IsRightHandDrive { get; set; }

        public YaponkaWithoutOverride() { }
        public YaponkaWithoutOverride(string vendor, string model, DateTime date, bool isRightHandDrive)
            : base(vendor, model, date) // base keyword is used to use a constructor from the base class
                                        // base can only refer to the parent class, no superclass 
        { IsRightHandDrive = isRightHandDrive; }

        public void Print()
        {
            Console.WriteLine("Vendor {0}", Vendor);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine(Date.ToString("MM/dd/yyyy"));
            Console.WriteLine((IsRightHandDrive) ? "Right hand drive" : "Left hand drive");
        }
    }
}
