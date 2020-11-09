using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualWallet
{
    class Account
    {
        private Dictionary<string, Fund> funds;
        private List<Fund> historicalFunds; 
        private string name;
        private decimal amount;

        public string Name { get => name; set => name = value; }
        public decimal Amount { get => amount; set => amount = value; }
        internal List<Fund> HistoricalFunds { get => historicalFunds; set => historicalFunds = value; }
        internal Dictionary<string, Fund> Funds { get => funds; set => funds = value; }

        public Account(string name, Dictionary<string, Fund> funds, List<Fund> historicalFunds, decimal amount = 0) 
        {
            Name = name;
            Amount = amount;
            Funds = funds;
            HistoricalFunds = historicalFunds;
        }

        public Account(string name, decimal amount = 0)
        {
            Name = name;
            Amount = amount;
            Funds = new Dictionary<string, Fund>();
            HistoricalFunds = new List<Fund>();
        }

        public bool CloseFund(Fund fund)
        {
            if (funds.Remove(fund.Name))
            {
                historicalFunds.Add(fund);
                return true;
            } else
            {
                return false; 
            }
        }

        public bool AddNewFund(Fund fund)
        {
            try
            {
                funds.Add(fund.Name, fund);
                return true;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("A Fund with Key = {1} already exists.", fund.Name);
                return false;
            }
        }
    }

   
}

