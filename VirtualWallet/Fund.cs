using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirtualWallet
{
    class Fund
    {
        private string name;
        private decimal amount;
        private string description; 
        private List<Transaction> transactions;
        private decimal goal; 

        public string Name { get => name; set => name = value; }
        public decimal Amount { get => amount; set => amount = value; }
        internal List<Transaction> Transactions {
            get 
            {
                if (transactions.Count == 0)
                {
                    return null;
                }
                else
                {
                    return transactions;
                }
            }
            set { transactions = value; }
        }

        public string Description { get => description; set => description = value; }
        public decimal Goal { get => goal; set => goal = value; }

        public Fund(string name, decimal amount, string description = "", decimal goal = 0)
        {
            Name = name;
            Amount = amount;
            Transactions = new List<Transaction>();
            Description = description;
            Goal = goal; 
        }

        public Fund(string name, decimal amount, List<Transaction> transactions, string description = "", decimal goal = 0) 
        {
            Name = name;
            Amount = amount;
            Transactions = transactions;
            Description = description;
            Goal = goal;
        }

        public bool AddTransaction(Transaction tran, string err)
        {
            if (tran != null)
            {
                if (0 > tran.Amount + Amount)
                {
                    Transactions.Add(tran);
                    Amount += tran.Amount;
                    return true;
                } else
                {
                    err = "ERROR02: You can't take more money than the Amount's total";
                    Console.WriteLine("You substract more money that the one you have in your account");
                    return false;
                }
                
            } else
            {
                err = "ERROR01: Null transaction";
                Console.WriteLine("Null pointer of transaction");
                return false;
            }
        }

        public bool IsGoalAchieved()
        {
            return Amount > Goal;
        }
    }
}
