using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualWallet
{
    class Controller
    {
        private Dictionary<string, Account> accounts;
        private List<Account> historicalAccounts;

        internal Dictionary<string, Account> Accounts { get => accounts; set => accounts = value; }
        internal List<Account> HistoricalAccounts { get => historicalAccounts; set => historicalAccounts = value; }

        public Controller()
        {
            Accounts = new Dictionary<string, Account>();
        }

        public Controller(Dictionary<string, Account> accounts)
        {
            Accounts = accounts;
        }

        public bool AddAccount(Account account)
        {
            try
            {
                accounts.Add(account.Name, account);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An Account with Key = {1} already exists.", account.Name);
                return false;
            }
            return true;
        }

    }
}
