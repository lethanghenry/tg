using ConsoleApplication2.dao;
using ConsoleApplication2.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.demo
{
    class DatabaseDemo
    {
        Database database = Database.GetInstance;
        List<Product> listProduct = new List<Product>();
        List<Accessory> listAccessory = new List<Accessory>();
        List<Category> listCategory = new List<Category>();
       
        public DatabaseDemo()
        {

        }


        public void insertTableTest()
        {
            object category = new Category(1,"thang");
            object product = new Product(2,"An",5);
            object accessory = new Accessory(3,"kim");

            
             database.insertTable("Category", category);
             database.insertTable("Product", product);
             database.insertTable("Accessory", accessory);
            

            
        }
        public void selectTableTest()
        {
            List<Object> listCategory = database.selectTable("Category","thang");
            List<Object> listProduct = database.selectTable("Product", "An");
            List<Object> listAccessory = database.selectTable("Accessory", "kim");
            foreach(Product p in listProduct)
            {
                Console.WriteLine(p);
            }
            foreach(Accessory a in listAccessory)
            {
                Console.WriteLine(a);
            }
            foreach(Category c in listCategory)
            {
                Console.WriteLine(c);
            }
        }

       public void updateTableTest()
        {
            
      
            object category = new Category(1, "nam");
            object product = new Product(2, "An", 5);
            object accessory = new Accessory(3, "kim");


            database.updateTable("Category", category);
            database.updateTable("Product", product);
            database.updateTable("Accessory", accessory);
           
           
        
        }

        public void deleteTableTest()
       { }
        public void truncateTableTest()
        { }
        public void initDatabase()
        {
            /*
             * add data from 3 class enity
             * Accessory
             * category
             * Product
             * 
             * 
             * */
           for(int i=0;i<10;i++)
           {
               listProduct[i].id = i;
               listProduct[i].name =i.ToString() ;
               listProduct[i].categoryId=i*10;
           }
            for(int i=0;i<10;i++)
            {
                listCategory[i].id = i + 10;
                listCategory[i].name = (i + 10).ToString();
            }
            for(int i=0;i<10;i++)
            {
                listAccessory[i].id = i + 20;
                listAccessory[i].name = (i + 20).ToString();
            }
        }
        public void printTable()
        { }

    }
}
