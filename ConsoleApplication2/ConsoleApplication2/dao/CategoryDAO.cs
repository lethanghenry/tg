using ConsoleApplication2.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.dao
{
    class CategoryDAO:BaseDao
    {
        Database database = Database.GetInstance;
        public override int insertTable(String name, object row)
        {
            Object category = new Category(1, "thang");
            return database.insertTable("Category", category);
          
        }
        public override int updateTable(string name, object row)
        {
            Object category = new Category(1, "thang");
            return database.updateTable("Category", category);
        }
        public override Boolean deleteTable(string name, object row)
        {
            Object category = new Category(1, "thang");
            return database.deleteTable("Category", category);
        }
        public List<Category> findAll()
        { }
        public Object findById(string name)
        { }

    }
}
