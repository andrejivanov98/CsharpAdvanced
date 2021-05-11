using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Invoice_app_program
{
    class Program
    {
        static void Main(string[] args)
        {

//---------------------------------Administrators----------------------------------------------------------------------------------------------------
            List<Administrator> administrators = new List<Administrator>
            {
                new Administrator("Andrej_123", "andrej_123", "EVN"),
                new Administrator("Ana_123", "ana_123", "Vodovod"),
                
            };
            //--------------------------------Users-------------------------------------------------------------------------------------------------------
            List<User> users = new List<User>
            {
                new User("Boban_123", "boban_123", 5000),
                new User("Marija_123", "marija_123", 3500)
            };

            //------------------------------------------------Functionalities and Data------------------------------------------------------------------------------------------------

            Console.WriteLine("WELCOME !!!");
            Console.WriteLine("In order to enter the application, please log in.");
            Console.WriteLine("Please enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string password = Console.ReadLine();


           User loginUser = users.FirstOrDefault(x => x.Login(username, password) != null);
           loginUser.Login(username, password);

             
             

            Invoice vodovod1 = new Invoice("Vodovod1", 350, new DateTime(2021, 5, 1), new DateTime(2021, 5, 10), false);
            loginUser.Invoices.Add(vodovod1);
            Invoice evn = new Invoice("EVN", 2200, new DateTime(2021, 5, 1), new DateTime(2021, 5, 20), false);
            loginUser.Invoices.Add(evn);
            Invoice vodovod2 = new Invoice("Vodovod2", 550, new DateTime(2021, 5, 1), new DateTime(2021, 5, 15), true);
            loginUser.Invoices.Add(vodovod2);


            static void MainMenu(User loginUser) {

               
                    Console.WriteLine("Choose an option that you want to do.");

                    Console.WriteLine("1. Check current Balance");
                    Console.WriteLine("2. Check how many invoices you had.");
                    Console.WriteLine("3. Increase you balance.");
                    Console.WriteLine("4. See list of paid invoices.");
                    Console.WriteLine("5. See list of unpaid invoices.");


                    string userAnswer = Console.ReadLine();

                    if (userAnswer == "1")
                    {
                        Console.WriteLine($"Your current balance is: {loginUser.CurrentBalance()} denars.");
                    }
                    if (userAnswer == "2")
                    {
                        Console.WriteLine($"Total number of unvoices that the user has are: {loginUser.CalculateUserInvoices()}.");
                    }
                    if (userAnswer == "3")
                    {
                        Console.WriteLine("How much money you want to add to your balance?");
                        string balanceAnswer = Console.ReadLine();
                        int increaseAmount;
                        bool successParse = int.TryParse(balanceAnswer, out increaseAmount);
                        if (!successParse)
                        {
                            Console.WriteLine("Wrong input for the first number");
                            return;
                        }

                        Console.WriteLine($"Your balance has increased to {loginUser.IncreaseBalance(increaseAmount)} denars.");
                    }
                    if (userAnswer == "4")
                    {
                        Console.WriteLine("This is the list of paid invoices:");
                        List<Invoice> paidInvoices = loginUser.CheckPaidInvoices();
                        foreach (Invoice invoice in paidInvoices)
                        {
                            Console.WriteLine($"{invoice.Company}");
                        }

                    }

                    if (userAnswer == "5")
                    {
                        Console.WriteLine("This is the list of unpaid invoices:");
                        List<Invoice> unpaidInvoices = loginUser.CheckUnpaidInvoices();
                        foreach (Invoice invoice in unpaidInvoices)
                        {
                            Console.WriteLine($"{invoice.Company}");
                        }

                    }
                

                
            }

            //static void MenuAdmin(Administrator loginAdmin, User loginUser)
            //{
            //    foreach(Invoice invoice in loginUser.Invoices)
            //    {
            //        if(loginAdmin.Company == invoice.Company)
            //        {
            //            Console.WriteLine($"{invoice.Company}");
            //        }
            //    }
            //}

            static void RepeatProcess(User loginUser)
            {
                while (true) { 
                Console.WriteLine("Do you want to proceed?");
                string proceedAnswer = Console.ReadLine().ToLower();
                bool proceedAnswerBool;


                if (proceedAnswer == "yes")
                {
                    proceedAnswerBool = true;
                }
                else if (proceedAnswer == "no")
                {
                    proceedAnswerBool = false;
                }
                else
                {
                    throw new Exception("Invalid entry.");

                }

                if(proceedAnswerBool == true)
                    {
                        MainMenu(loginUser);
                    }
                else if(proceedAnswerBool == false)
                    {
                        Environment.Exit(0);  
                    }

                }
            }

   

            while (true)
            {
                try
                {

                    if (loginUser.IsAdmin == false)
                    {
                        MainMenu(loginUser);
                        while (true)
                        {
                            RepeatProcess(loginUser);
                        }





                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

            }


        }
    }
}
