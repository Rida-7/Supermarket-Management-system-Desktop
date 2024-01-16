using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBusiness_.BL
{
    public class Product
    {
        private string category;
        private string name;
        private int quantity;
        private int price;

        public string Category { get => category; set => category = value; }
        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }

        public TheUser TheUser
        {
            get => default;
            set
            {
            }
        }

        public Customer Customer
        {
            get => default;
            set
            {
            }
        }

        public Product(string category, string name, int quantity, int price)
        {
            this.Category = category;
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
        }

        public void setCategory(string category)
        {
            this.Category = category;
        }

        public string getcategory()
        {
            return this.Category;
        }

        public void setName(string name)
        {
            this.Name = name;
        }

        public string getName()
        {
            return this.Name;
        }

        public void setQuantity(int quantity)
        {
            this.Quantity = quantity;
        }

        public int getQuantity()
        {
            return this.Quantity;
        }

        public void setPrice(int price)
        {
            this.Price = price;
        }

        public int getPrice()
        {
            return this.Price;
        }

        public float calculateTax()
        {
            float tax = 0;
            if (Category == "grocery" || Category == "Grocery")
            {
                tax = (float) (Price * 0.1);
            }
            else if (Category == "fruit" || Category == "Fruit")
            {
                tax = (float)(Price * 0.05);
            }
            else
            {
                tax = (float)(Price * 0.15);
            }
            return tax;
        }
    }
}
