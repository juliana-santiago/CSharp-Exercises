using InheritanceExample.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 500.0); Parou de funcionar porque a class account agora é abstrata 
            BusinessAccount bacc = new BusinessAccount(1002, "Pedro", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Rafaela", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 500.0, 0.01);

            //DOWNCASTING
            BusinessAccount bacc1 = (BusinessAccount)acc2;
            bacc1.Loan(100.0);

            if(acc3 is BusinessAccount)
            {
                BusinessAccount bacc2 = (BusinessAccount)acc3;
            }

            //acc.Withdraw(10.0);
            acc3.Withdraw(10.0);

            //Console.WriteLine(acc.Balance);
            //Console.WriteLine(acc3.Balance);

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new SavingsAccount(1002, "Bob", 500.00, 0.01));
            list.Add(new BusinessAccount(1003, "Maria", 500.00, 400.00));
            list.Add(new BusinessAccount(1004, "Anna", 500.00, 500.00));

            double sum = 0.0;

            foreach(Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach(Account account in list)
            {
                account.Withdraw(10.0);
            }

            foreach (Account account in list)
            {
                Console.WriteLine($"Updated balance for account {account.Number}: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
