using Microsoft.VisualStudio.TestTools.UnitTesting;
using Add_Item_To_Shopping_Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Item_To_Shopping_Cart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void AddProductToCartTest()
        {
            //create local instances of needed objects

            ShoppingCart testCart = new ShoppingCart(null);
            Product p1 = new Product(25, "TV", "56 inch Qled tv", 2200);

            //initial count of the products 
            int initialArraySize = testCart.ProductList.Count;

            //add one product
            testCart.AddProductToCart(p1);

            //first we check if the array is not null, then we check if just one product is added in the cart 
            Assert.IsNotNull(testCart.ProductList);
            Assert.AreEqual(initialArraySize + 1, testCart.ProductList.Count);

        }

        [TestMethod()]
        public void AddProductPriceTest()
        {
            //create a local instance of a shopping cart object
            ShoppingCart testCart = new ShoppingCart(null);

            //initial total price of the cart
            int initialCartTotal = testCart.GetCartPrice();

            //we add a new value to the total price, and we test if it is added to the initial total price
            testCart.AddProductPrice(500);
            testCart.AddProductPrice(500);
            Assert.AreEqual(initialCartTotal + 1000, testCart.GetCartPrice());
        }

        [TestMethod()]
        public void RemoveProductFromCartTest()
        {
            //create local instances of needed objects

            ShoppingCart testCart = new ShoppingCart(null);
            Product p1 = new Product(25, "TV", "56 inch Qled tv", 2200);
            Product p2 = new Product(25, "TV", "42 inch Qled tv", 800);

            testCart.AddProductToCart(p1);
            testCart.AddProductToCart(p1);

            //initial number of products in the shopping cart
            int initialArraySize = testCart.ProductList.Count;

            //remove one product from the cart
            testCart.RemoveProductFromCart(p1);
            Assert.AreEqual(initialArraySize - 1, testCart.ProductList.Count);

        }

        [TestMethod()]
        public void SubtractProductPriceTest()
        {
            //create a local instance of a shopping cart object
            ShoppingCart testCart = new ShoppingCart(null);

            //initial total price of the cart
            int initialCartTotal = testCart.GetCartPrice();

            //we remove a new value from the total price, and we test if the total price is updated
            testCart.SubtractProductPrice(500);
            Assert.AreEqual(initialCartTotal - 500, testCart.GetCartPrice());
        }
    }
}