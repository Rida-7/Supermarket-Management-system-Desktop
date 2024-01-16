using projectBusiness_.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projectBusiness_.DL
{
    public class CustomerDL
    {
        private static List<Customer> orders = new List<Customer>();

        public static void addToList(Customer p)
        {
            orders.Add(p);
        }

        public static List<Customer> getOrders()
        {
            return orders;
        }

        /* public static void addToFile(string path, Customer p)
        {
            StreamWriter f = new StreamWriter(path, true);
            string products = "";
            for(int i = 0; i < p.getBuyedProducts().Count; i++)
            {
                products = products + p.getBuyedProducts()[i].getName() + ";" + p.getBuyedProducts()[i].getQuantity() + "!";
            }
            // products = products + p.getBuyedProducts()[p.getBuyedProducts().Count - 1].getName();

            f.WriteLine(p.getUserName() + "," + products);
            f.Flush();
            f.Close();
        }*/

        public static void addToFile(string path, Customer p)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(p.getUserName() + "," + p.P.Category + "," + p.P.Name + "," + p.P.Quantity, p.P.Price);
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string category = splittedRecord[1];
                    string pname = (splittedRecord[2]);
                    int quantity = int.Parse(splittedRecord[3]);
                    int price = int.Parse(splittedRecord[4]);
                    Product p = new Product(category, pname, quantity, price);
                    Customer c = new Customer(name, p);
                    addToList(c);
                }
                f.Close();
                return true;
            }
            return false;
        }

        /* public static bool readFromFile(string path)
         {
             StreamReader f = new StreamReader(path);
             string line;
             if (File.Exists(path))
             {
                 while((line = f.ReadLine()) != null)
                 {
                     string[] splittedRecord = line.Split(',');
                     string name = splittedRecord[0];
                     string[] splittedRecordforProducts = splittedRecord[1].Split('!');
                     List<Product> temp = new List<Product>();
                     for (int i = 0; i < splittedRecordforProducts.Length; i++)
                     {
                         string[] pr = splittedRecordforProducts[i].Split(';');
                         string pName = pr[0];
                         int quantity = int.Parse(pr[1]);
                         Product p = ProductDL.isProductExists(pName);
                         if (p != null)
                         {
                             p.setQuantity(quantity);
                             int price = p.getPrice() * p.getQuantity();
                             p.setPrice(price);
                             temp.Add(p);
                         }
                     }
                     Customer customer = new Customer(name, temp);
                     addToList(customer);
                 }
                 f.Close();
                 return true;
             }
             return false;
         } */

        public static void viewOrders()
        {
            string products;
            foreach(Customer p in orders)
            {
                products = "";
                for(int i = 0; i < p.getBuyedProducts().Count; i++)
                {
                    products = products + p.getBuyedProducts()[i].getName() + "\t" + p.getBuyedProducts()[i].getQuantity() + "\t" + p.getBuyedProducts()[i].getPrice() + "\t";
                }
                Console.WriteLine(p.getUserName() + "\t" + products);
            }
        }

        public static List<Customer> viewCart(string name)
        {
            List<Customer> cart = new List<Customer>();
            foreach(Customer p in orders)
            {
                if (p.getUserName() == name)
                {
                    cart.Add(p);
                    
                }
            }
            return cart;
        }

        public static int getBill(string username)
        {
            int bill = 0;
            foreach(Customer c in orders)
            {
                if (c.getUserName() == username)
                {
                    for (int i = 0; i < c.getBuyedProducts().Count; i++)
                    {
                        bill = bill + c.getBuyedProducts()[i].getPrice();
                    }
                }
               // Console.WriteLine("{0} has Bill {1} ", c.getUserName(), bill);
            }
            return bill;
        }
    }
}
