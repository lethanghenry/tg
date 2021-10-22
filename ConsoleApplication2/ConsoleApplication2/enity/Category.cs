using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.enity
{
    class Category:BaseRow
    {
        // constructor in abstract in BaseRow
        
        public Category()
        { }

        public Category(int _id, string _name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return "\t" + this.id + "\t" + this.name;
        }
    }
}
