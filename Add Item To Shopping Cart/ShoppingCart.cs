using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_Item_To_Shopping_Cart
{
    public class ShoppingCart
    {
        private Customer CartOwner;
        private int CartID;
        private int CartPrice;
        public ArrayList ProductList;

        //constructor ,every time a new shopping cart is created the cart id is increased by 1 
        //an empty array of products is added
        //the total price of the cart is initialized to zero
        public ShoppingCart(Customer Cartowner)
        {
            this.CartOwner = Cartowner;
            this.CartID++;
            ProductList = new ArrayList();
            CartPrice = 0;

        }

        //getters
        public Customer GetCustomer()
        {
            return this.CartOwner;
        }

        public int GetCartID()
        {
            return this.CartID;
        }

        public int GetCartPrice()
        {
            return this.CartPrice;
        }

        //add a product to the shopping cart
        //call the caculate price
        public void AddProductToCart(Product product)
        {
            this.ProductList.Add(product);
            AddProductPrice(product.GetProductPrice());
        }

        //calculate the shopping cart total
        public void AddProductPrice(int price)
        {
            CartPrice += price;
        }

        //remove a product from the shoping cart
        public void RemoveProductFromCart(Product product)
        {
            this.ProductList.Remove(product);
            SubtractProductPrice(product.GetProductPrice());
        }

        public void SubtractProductPrice(int price)
        {
            this.CartPrice -= price;
        }

    }
}