using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_Item_To_Shopping_Cart
{
    public class Product
    {
        private int ProductId;
        private string ProductName;
        private string ProductDescription;
        private int ProductPrice;

        //constructor
        public Product(int ProdcutId, string PN, string PD, int PP)
        {
            this.ProductId = ProdcutId;
            this.ProductName = PN;
            this.ProductDescription = PD;
            this.ProductPrice = PP;
        }

        //getters
        public int GetProductPrice()
        {
            return this.ProductPrice;
        }

        public int GetProductId()
        {
            return this.ProductId;
        }
    }
}