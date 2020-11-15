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
        private string description; 

        public string Name { get => name; set => name = value; }
        public decimal Amount { get => amount; set => amount = value; }
        internal List<Fund> HistoricalFunds { get => historicalFunds; set => historicalFunds = value; }
        internal Dictionary<string, Fund> Funds { get => funds; set => funds = value; }
        public string Description { get => description; set => description = value; }

        public Account(string name, Dictionary<string, Fund> funds, List<Fund> historicalFunds, string description = "") 
        {
            Name = name;           
            Funds = funds;
            HistoricalFunds = historicalFunds;
            Description = description;
            Amount = 0;
        }

        public Account(string name, string description = "")
        {
            Name = name;
            Amount = 0;
            Funds = new Dictionary<string, Fund>();
            HistoricalFunds = new List<Fund>();
            Description = description;
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

        public void ClearHistoricalFunds()
        {
            HistoricalFunds = new List<Fund>();
        }
    }

   
}

