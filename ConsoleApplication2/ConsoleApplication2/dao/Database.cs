using ConsoleApplication2.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.dao

{
  
    class  Database:BaseDao
    {
        public Array productTable { get; set; }
        public Array categoryTable { get; set; }
        public Array accessoryTable { get; set; }
        public Database instants { get; set; }

        private Database()
        { }
        private static Database instance = null;
       public static Database GetInstance
        {
            get
            {
                if(instance==null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }

       private static List<Product> listProduct = null;
       public static List<Product> GetListProduct
       {
           get
           { 
               if(listProduct==null)
                {
                    listProduct = new List<Product>();
                 }
               return listProduct;
           }
           
       }

       private static List<Category> listCategory = null;
       public static List<Category> GetListCategory
       {
           get
           {
               if(listCategory==null)
               {
                   listCategory = new List<Category>();
               }
               return listCategory;
           }
       }
       private static List<Accessory> listAccessory = null;
       private static List<Accessory> GetListAccessory
       {
           get
           {
               if (listAccessory == null)
               {
                   listAccessory = new List<Accessory>();
               }
               return listAccessory;
           }
       }


       //insert Table
       public override int insertTable(string name,object row)
       {
           /*
            * param name, row (object)
            * Insert Table
            * 
            * 
            * 
            * return int =0 or =1
            * 
            * */
        
           if(String.Compare(name,"Category")==0)
           {
               Category category = (Category)row;
               listCategory.Add(category);
               return listCategory.Count;
           } 
           else if(String.Compare(name,"Product")==0)
           {
               Product product = (Product)row;
               listProduct.Add(product);
               return listProduct.Count;
           }
           else if(String.Compare(name,"Accessory")==0)
           {
               Accessory accessory = (Accessory)row;
               listAccessory.Add(accessory);
               return listAccessory.Count;
           }
           return 0;
       }

       //update Table
       public override int updateTable(string name,object row)
       {
           /*
           * param name, row (object)
           * update Table
           * 
           * 
           * 
           * return int id or =0 if do not have id
           * 
           * */
           if(String.Compare(name,"Product")==0)
           {
               Product product = (Product)row;
               foreach(Product p in listProduct)
               {
                   if(p.id==product.id)
                   {
                       p.name = product.name;
                       p.categoryId = product.categoryId;
                       return p.id;
                   }
                   else
                   {
                       return 0;
                   }
               }
               
               
           }
           else if(String.Compare(name,"Accessory")==0)
           {
               Accessory accessory = (Accessory)row;
               foreach(Accessory a in listAccessory)
               {
                   if(a.id==accessory.id)
                   {
                       a.name = accessory.name;
                       return a.id;
                   }
                   else
                   {
                       return 0;
                   }
               }

           }
           else if(String.Compare(name,"Category")==0)
               {
                   Category category = (Category)row;
               foreach(Category c in listCategory)
               {
                   if(c.id==category.id)
                   {
                       c.name = category.name;
                   }
                   else
                   {
                       return 0;
                   }
               }
               }
           return 0;
       }
       //delete Table
       public override Boolean deleteTable(string name,object row)
       {
           /*
           * param name, row (object)
           * 
           * delete Table
           * 
           * 
           * return int =true or =false
           * 
           * */
           if(String.Compare(name,"Category")==0)
           {
               Category category=(Category)row;
               foreach(Category c in listCategory)
               {
                   if (c.id == category.id)
                   {
                       listCategory.Remove(c);
                       return true;
                   }
                   else
                       return false;
               }
           }
           else
               if(String.Compare(name,"Product")==0)
           {
               Product product = (Product)row;
               foreach(Product p in listProduct)
               {
                   if (p.id == product.id)
                   {
                       listProduct.Remove(p);
                       return true;
                   }
                   else return false;
               }
           }
               else
                   if(String.Compare(name,"Accessory")==0)
                   {
                       Accessory accessory = (Accessory)row;
                       foreach(Accessory a in listAccessory)
                       {
                           if (a.id == accessory.id)
                           {
                               listAccessory.Remove(a);
                               return true;
                           }
                           else
                               return false;
                       }
                   }
           return false;

       }
       //truncate Table
       public void truncateTable(string name)
       {
           /*
           * param name)
           * 
           * 
           * 
           * 
           * return void    
           * 
           * */
           if(String.Compare(name,"Product")==0)
           {
               listProduct.Clear();
           }
           else if(String.Compare(name,"Accessory")==0)
           {
               listAccessory.Clear();
           }
           else if(String.Compare(name,"Category")==0)
           {
               listCategory.Clear();
           }
       }

        //select Table
       public  List<object> selectTable(string name, string where)
       {
           List<Category> listCategorySelect = new List<Category>();
           List<Accessory> listAccessorySelect = new List<Accessory>();
           List<Product> listProductSelect = new List<Product>();
           if(String.Compare(name,"Category")==0)
           {
               foreach(Category c in listCategory)
               {
                   if(String.Compare(c.name,where)==0)
                   {
                       listCategorySelect.Add(c);
                       
                   }
               }
               return listAccessorySelect.Cast<Object>().ToList();
           }
           else   if(String.Compare(name,"Accessory")==0)
           {
               foreach(Accessory a in listAccessory)
               {
                   if(String.Compare(a.name,where)==0)
                   {
                       listAccessorySelect.Add(a);
                   }
               }
               return listAccessorySelect.Cast<Object>().ToList();
           }
           else if(String.Compare(name,"Product")==0)
           {
               foreach(Product p in listProductSelect)
               {
                   if(String.Compare(p.name,where)==0)
                   {
                       listProductSelect.Add(p);
                   }
               }
               return listProductSelect.Cast<Object>().ToList();
           }
           return null;

       }
     


        public Database(Array productTable,Array categoryTable,Array accessoryTable,Database instants)
        {
            this.productTable = productTable;
            this.categoryTable = categoryTable;
            this.accessoryTable = accessoryTable;
            this.instants = instants;
        }
        public string toString()
        {
            return "\t" + this.productTable + "\t" + this.categoryTable + "\t" + this.accessoryTable + "\t" + this.instants;
        }
      
        
       
       
       
    }
}
