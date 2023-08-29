using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
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

        public Car (string vendor, string model, DateTime date) : this(vendor, model)
        {
            Date = date;
        }
    }
}
