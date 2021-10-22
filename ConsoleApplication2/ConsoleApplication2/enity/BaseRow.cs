using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.enity
{
   abstract class BaseRow
    {
    
      public  int id
      {
          get;
        set;
      }
      public  string name
      {
          get;
         set;
      }



     //  protected abstract BaseRow()
     // { }
     //protected abstract  BaseRow(int id,string name)
     //  {
     //      this.id = id;
     //      this.name = name;
     //  }
   

    }
}
