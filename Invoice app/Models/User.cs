using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User : Human
    {

        public int Balance { get; set; }
        public List<Invoice> Invoices { get; set; }

        public int Sum { get; set; }

        public int TotalUserInvoices { get; set; }






        public User(string username, string password, int balance, List<Invoice> invoices) : base(username, password, false)
        {
            Balance = balance;
            Invoices = invoices;
            Sum = 0;
            TotalUserInvoices = 0;

        }

        public User(string username, string password, int balance) : base(username, password, false)
        {
            Balance = balance;
            Invoices = new List<Invoice>();
            Sum = 0;
            TotalUserInvoices = 0;

        }

        public int CurrentBalance()
        {

            foreach (Invoice invoice in Invoices)
            {
                if (invoice.InvoiceStatus == true)
                {
                    Sum += invoice.Amount;
                }

            }

            int currentBalance = Balance - Sum;
            return currentBalance;

        }

        public List <Invoice> CheckPaidInvoices()
        {
           List<Invoice> ListOfPaidInvoices = new List<Invoice>();


            foreach (Invoice invoice in Invoices)
            {
                if (invoice.InvoiceStatus == true)
                {
                    ListOfPaidInvoices.Add(invoice);
                   
                }

            }
            return ListOfPaidInvoices;

        }


        public List<Invoice> CheckUnpaidInvoices()
        {
            List<Invoice> ListOfUnpaidInvoices = new List<Invoice>();


            foreach (Invoice invoice in Invoices)
            {
                if (invoice.InvoiceStatus == false)
                {
                    ListOfUnpaidInvoices.Add(invoice);

                }

            }
            return ListOfUnpaidInvoices;

        }

        public int CalculateUserInvoices()
        {
            TotalUserInvoices += Invoices.Count();
            return TotalUserInvoices;
        }

        public int IncreaseBalance(int inflow)
        {
            foreach (Invoice invoice in Invoices)
            {
                if (invoice.InvoiceStatus == true)
                {
                    Sum += invoice.Amount;
                }

            }

           
            int currentBalance = Balance - Sum;
            int newCurrentBalance = currentBalance + inflow;
            return newCurrentBalance;
           
        }



    }
}

    

