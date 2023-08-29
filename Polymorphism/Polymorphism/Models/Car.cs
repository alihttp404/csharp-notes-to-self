using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Car
    {
        public Guid ID { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public DateTime Date { get; set; }

        public Car() { }

        public Car(string vendor, string model) : this() // this() keyword is used in place of the class name itself. Car() would be the c++ equivalent
        {
            ID = Guid.NewGuid();
            Vendor = vendor;
            Model = model;
        }

        public Car(string vendor, string model, DateTime date) : this(vendor, model)
        {
            Date = date;
        }

        public virtual void Print()
        {
            Console.WriteLine("Vendor {0}", Vendor);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine(Date.ToString("MM/dd/yyyy"));
        }
    }

    internal class CarWithoutOverride
    {
        public Guid ID { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public DateTime Date { get; set; }

        public CarWithoutOverride() { }

        public CarWithoutOverride(string vendor, string model) : this() // this() keyword is used in place of the class name itself. Car() would be the c++ equivalent
        {
            ID = Guid.NewGuid();
            Vendor = vendor;
            Model = model;
        }

        public CarWithoutOverride(string vendor, string model, DateTime date) : this(vendor, model)
        {
            Date = date;
        }

        public  void Print()
        {
            Console.WriteLine("Vendor {0}", Vendor);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine(Date.ToString("MM/dd/yyyy"));
        }
    }
}
