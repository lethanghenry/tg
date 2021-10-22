using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.enity
{
    class Accessory:BaseRow
    {


      
      
        
        public Accessory()
        { }

        public Accessory(int _id, string _name)
        {
            _id= id;
           _name = name;
        }

    public string toString()
        {
            return "\t" + this.id + "\t" + this.name;
        }
    }
}
