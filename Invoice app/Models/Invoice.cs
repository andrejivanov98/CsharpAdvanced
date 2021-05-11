using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Invoice
    {
        public string Company { get; set; }
        public int Amount { get; set; } 
        public DateTime DueDate { get; set; }
        public DateTime DateIssued { get; set; }
        public bool InvoiceStatus { get; set; } = false; 

        public Invoice(string company, int amount, DateTime dueDate, DateTime dateIssued, bool invoiceStatus)
        {
            Company = company;
            Amount = amount;
            DueDate = dueDate;
            DateIssued = dateIssued;
            InvoiceStatus = invoiceStatus;
        }

        public Invoice()
        {

        }
        public int CheckInvoiceDeadline(DateTime nowDate)
        {
            int daysLate = (nowDate - DueDate).Days;
            if(nowDate > DueDate)
            {
                Amount += (daysLate * 10);
                return Amount;
            }
            else
            {
                return Amount;
            }
        }

        

       

    }
}
