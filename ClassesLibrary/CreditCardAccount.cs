using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    class CreditCardAccount
    {
        //fields
        private int _acountNumber;
        private string _customerInfo;
        private decimal _balance;
        private bool _isPastDue;
        private decimal _annualInterestRate;

        //properties
        public int AccountNumber { get; set; }
        public string CustomerInfo { get; set; }
        public Decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //ctor
        public CreditCardAccount(int accountNumber, string customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = CustomerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public CreditCardAccount()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("Account Number: {0}" +
                "Customer Info: {1}" +
                "Balance: {2}" +
                "Is Past Due: {3}" +
                "Annual Interest Rate: {4}", 
                AccountNumber, CustomerInfo, Balance, IsPastDue, AnnualInterestRate);
        }
    }
}
