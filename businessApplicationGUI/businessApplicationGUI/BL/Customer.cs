using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectBusiness_.BL
{
    public class Customer : TheUser
    {
        private List<Product> buyedProducts = new List<Product>();
        private Product p;
        
        public Customer(string username, string password) : base(username, password)
        {
            this.username = username;
            this.password = password;
        }
        public Customer (string username, List<Product> p) 
        {
            this.username = username;
            buyedProducts = p;
        }
        public Customer(string username, Product p)
        {
            this.username = username;
            this.P = p;
        }

        
        public Product P { get => p; set => p = value; }
        
        

        public List<Product> getBuyedProducts()
        {
            return buyedProducts;
        }

    }
}
