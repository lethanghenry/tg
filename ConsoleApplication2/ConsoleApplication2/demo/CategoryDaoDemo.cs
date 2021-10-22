using ConsoleApplication2.dao;
using ConsoleApplication2.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.demo
{
    class CategoryDaoDemo:Database
    {
        Database database = Database.GetInstance;
        public void insertTest()
        {
            object category = new Category(1, "thang");
            database.insertTable("Category", category);
        }
        public void findAllTest()
        { }
        public void updateTest()
        {
            object category = new Category(1, "thang dep zai");
            database.updateTable("Category", category);
        }
    }
}
