using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
    internal class Record
    {

    }

    // record is like class, but used for data transfers mainly
    /*
     * record is an optimized version of class
     * it is used only for fields
     * it can contain methods, but that destroys its point
     * data inside can't be later modified from outside
     * a thing called data mapping is used to transfer info of an object somewhere:
     *      for example, there are 25 fields and methods in class, which makes it very heavy
     *      say you only want 7 fields, like id, name, birth of date, and etc.
     *      transferring the entire object for those 7 objects is very inefficient
     *      it causes serious performance problems
     *      therefore, when transferring some data, we map the data needed to be transferred from the class to a record and send that record
     */
    record Person
    {
        
    }
}
