using projectBusiness_.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projectBusiness_.DL
{
    public class ProductDL
    {
        private static List<Product> products = new List<Product>();

        public static Product isProductExists(string name)
        {
            foreach(Product p in products)
            {
                if (p.getName() == name)
                {
                    return p;
                }
            }
            return null;
        }

        public static List<Product> getProduct()
        {
            return products;
        }

        public static void viewProduct()
        {
            Console.WriteLine("Category\tNAme\tQuantity\tPrice");
            foreach(Product p in products)
            {
                Console.WriteLine(p.getcategory() + "\t" + p.getName() + "\t" + p.getQuantity() + "\t" + p.getPrice());
            }
        }

        public static void addToList(Product p)
        {
            products.Add(p);
        }

        public static void addToFile(string path, Product p)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(p.getcategory() + "," + p.getName() + "," + p.getQuantity() + "," + p.getPrice());
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
                    string category = splittedRecord[0];
                    string name = splittedRecord[1];
                    int quantity = int.Parse(splittedRecord[2]);
                    int price = int.Parse(splittedRecord[3]);
                    Product p = new Product(category, name, quantity, price);
                    addToList(p);
                }
                f.Close();
                return true;
            }
            return false;
        }

        public static void deleteProduct(Product p)
        {
            products.Remove(p);
        }

        public static void updateProduct(Product previous, Product updated)
        {
            foreach(Product p in products)
            {
                if (p.Name == previous.Name && p.Price == previous.Price)
                {
                    p.Name = updated.Name;
                    p.Category = updated.Category;
                    p.Price = updated.Price;
                    p.Quantity = updated.Quantity;
                }
            }
        }

       // public static float calculateTax(Product p)
       // {
         //   float tax;
           // foreach (Product p in products)
           // {
          //      tax = p.calculateTax();
               
           // }
        //    return tax;
       // }
    }
}
