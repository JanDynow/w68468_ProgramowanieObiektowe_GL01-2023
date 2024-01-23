using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Bank
{
    public class Account
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public static double Income { get; set; }
        public static double Expense { get; set; }

        public void DisplaySumary()
        {
            Console.WriteLine($"Income: {Income}, Expense: {Expense}, Total: {Income + Expense}");
        }

        public void Add(Transaction transaction)
        {
            Transactions.Add(transaction);
            transaction.ProcessTransaction();
        }
    }
}
