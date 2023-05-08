using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Item_To_Shopping_Cart
{
    public class Customer
    {
        //instance variables
        private string FirstName;
        private string LastName;
        private string Email;
        private string PhoneNumber;
        private int AccountNumber;

        
        //constructor with five parameters
        public Customer(string firstName, string lastName, string email, string phoneNumber, int accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            AccountNumber = accountNumber;
        }

        //method to display the customer info
        public void CustomerInfo()
        {

            //string info = "Customer Name: " + FirstName + " " + LastName + "\nCustomer Phone Number: " + PhoneNumber +
            //   "\nCustomer Email: " + Email + "\nAccount Number: " + AccountNumber;

            Console.Write("Customer First Name:  {0} \nCustomer Last Name: {1} \nCustomer Phone Number: {2} \nCustomer Email: {3} \nAccount Number: {4}", FirstName, LastName, PhoneNumber, Email, AccountNumber);
        }

    }

}
