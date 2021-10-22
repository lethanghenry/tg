using ConsoleApplication2.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.demo
{
    class ProductDaoDemo
    {
        Database database = Database.GetInstance;
        public void insertTableProductTest()
        {
            object product = new Product(2, "An", 5);
            database.insertTable("Product", product);

        }
        public void selectTableProductTest()
        {
            List<Object> listProduct = database.selectTable("Product", "An");
            foreach (Product p in listProduct)
            {
                Console.WriteLine(p);
            }
        }
        public void updateTableProductTest()
        {
            object product = new Product(2, "An", 5);
            database.updateTable("Product", product);
          
        }
        public void deleteTableProductTest()
        {
            
            object product = new Product(2, "An", 5);
            database.deleteTable("Product", product);
        }
        public void truncateTableProductTest()
        {
            database.truncateTable("Product");
        }

    }
}
