using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        { }

            public class Date
        {
        }

        public class Customer
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }

        public class Cash
        {
            public string Status { get; set; }

            public float CalcSubTotal()
            {
                return 0.0f;
            }

            public float CalcTax()
            {
                return 0.0f;
            }
            public float CalcTotal()
            {
                return 0.0f;
            }

            public float CalcTotalWeight()
            {
                return 0.0f;
            }
        }

        public class Payment
        {
            public float Amount { get; set; }
        }

        public class Check : Payment
        {
            public float CashTendered { get; set; }
            public string Name { get; set; }
            public string BankID { get; set; }

            public void Authorized()
            {
            }
        }

        public class OrderDetail

        
    {
    public int Quantity { get; set; }
    public string TaxStatus { get; set; }

    public float CalcSubTotal()
    {
        return 0.0f;
    }

    public float CalcWeight()
    {
        return 0.0f;
    }

    public float CalcTax()
    {
        return 0.0f;
    }
}

public class Item
{
    public float ShippingWeight { get; set; }
    public string Description { get; set; }

    public float GetPriceForQuantity(int quantity)
    {
        return 0.0f;
    }
            public float GetTax()
            {
                return 0.0f;
            }

            public bool InStock()
            {
                return true;
            }
        }

        public class Credit : Payment
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public DateTime ExpiryDate { get; set; }

            public void Authorized()
            {
            }
        }

        public class Order
        {
            public Date Date { get; set; }
            public Customer Customer { get; set; }
            public Cash Cash { get; set; }
            public Payment Payment { get; set; }
            public OrderDetail OrderDetail { get; set; }
        }
    }
}
