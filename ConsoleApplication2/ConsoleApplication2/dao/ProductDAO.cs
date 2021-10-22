using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.dao
{
    class ProductDAO:BaseDao
    {
        Database database = Database.GetInstance;
        public override int insertTable(String name, object row)
        {
            object product = new Product(2, "An", 5);
           return database.insertTable("Product", product);
            }
        public override int updateTable(String name, object row)
        {
            object product = new Product(2, "An", 5);
            return database.updateTable("Product", product);
        }
        public override Boolean deleteTable(String name, object row)
        {
            object product = new Product(2, "An", 5);
            return database.deleteTable("Product", product);
        }
        public List<Product> findAll()
        { }
        public Product findById(string name)
        { }
        public Product findByName(string name)
        { }
        public List<Product> search(string where)
        { }

    }
}
