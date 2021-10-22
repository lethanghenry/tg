using ConsoleApplication2.enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.dao
{
    class AccessoryDAO:BaseDao
    {
        Database database = Database.GetInstance;
        List<Accessory> listAccessory = new List<Accessory>();
        public override int  insertTable(string name,object row)
        {
            object accessory = new Accessory(3, "kim");
            return database.insertTable("Accessory", accessory);
            
        }

        public void selectTableAccessoryTest()
        {
            List<Object> listAccessory = database.selectTable("Accessory", "kim");
            foreach (Accessory a in listAccessory)
            {
                Console.WriteLine(a);
            }
        }
        public override int updateTable(string name,object row)
        {
            object accessory = new Accessory(3, "kim");
            return database.updateTable("Accessory", accessory);
           
        }
        public override Boolean deleteTable(string name, object row)
        { 
             object accessory = new Accessory(3, "kim");
                   return database.deleteTable("Accessory", accessory);
            
        }
        public void truncateTableAccessoryTest()
        { }
        public void initAccessoryDatabase()
        {
            for (int i = 0; i < 10; i++)
            {
                listAccessory[i].id = i + 20;
                listAccessory[i].name = (i + 20).ToString();
            }
        }
        public void printTableAccessory()
        { }

    }
}
