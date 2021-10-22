using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.dao
{
   abstract class BaseDao
    {
       public abstract int insertTable(string name,object row);

       public abstract int updateTable(string name, object row);

       public abstract Boolean deleteTable(string name, object row);
     
       
    }
}
