using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Item_To_Shopping_Cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a Item to Shopping Cart\n");

            //create an object Customer
            Customer customer1 = new Customer("Daniel", "Craig", "dc007@gmail.com", "0035388745007", 7);


            //create a Shopping Cart object and make custumer1 the owner
            ShoppingCart cart = new ShoppingCart(customer1);

            //display the cart owner info
            Console.Write("\n\nThe owner of the shoping cart {0} is:\n", cart.GetCartID());
            cart.GetCustomer().CustomerInfo();

            //create a few products objects
            Product p1 = new Product(25, "TV", "56 inch Qled tv", 2200);
            Product p2 = new Product(26, "Sofa", "Three seater sofa", 1800);
            Product p3 = new Product(27, "Sound-System", "7.1 movie theater system", 900);
            Product p4 = new Product(28, "TV Stand", "Dark chesnut luxury tv stand", 700);
            Product p5 = new Product(29, "Coffe table", "Light Chesnut coffe table", 400);
            Product p6 = new Product(30, "Blue-Ray", "James Bond : Die Another Day", 11);


            Console.Write("\n\nThe shoping cart contains {0}  products", cart.ProductList.Count);
            //add products to the shoping cart
            cart.AddProductToCart(p1);
            cart.AddProductToCart(p2);
            cart.AddProductToCart(p6);

            //display the total price of the cart

            Console.Write("\n\nThe shoping cart contains {0}  products", cart.ProductList.Count);
            Console.Write("\nThe total price of customer shopping cart is {0}", cart.GetCartPrice());

            //remove a product
            cart.RemoveProductFromCart(p6);


            //display the total price of the cart

            Console.Write("\n\nThe shoping cart contains {0} products", cart.ProductList.Count);
            Console.Write("\nThe total price of customer shopping cart is {0}", cart.GetCartPrice());


            Console.ReadKey();
        }
    }
}
