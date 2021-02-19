using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    class Customer
    {
        //field
        private string _customerID;
        private string _firstName;
        private string _lastName;
        private string _customerInformation;

        //properties
             public string CustomerId { get; set; }
             public string FirstName { get; set; }
             public string LastName { get; set; }
             public  string CustomerInformation { get; set; }

        //ctors
        public Customer(string customerId, string firstName, string lastName, string customerInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            CustomerInformation = customerInformation;
        }

        public Customer()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("CustomerId: {0}\n" +
                "First Name: {1}\n" +
                "Last Name: {2}\n" +
                "Customer Information: {4}\n",
                CustomerId, FirstName, LastName, CustomerInformation);
        }
    }
}
