
using ConsoleApplication2.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Product:BaseRow
    {
        // constructor in abstract in BaseRow
        


        public int categoryId { get; set; }
        
        public Product()
        { }

        public Product(int _id, string _name,int _categoryId)
        {
            _id = id;
            _name = name;
            _categoryId = categoryId;
        }

        public String toString()
        {
            return "\t" + this.id + "\t" + this.name + "\t" + this.categoryId;
        }
    }
}
