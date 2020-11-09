using System;

namespace VirtualWallet
{
    class Transaction
    {
        private DateTime date;
        private decimal amount;
        private string sourceAccount;
        private string destinyAccount;
        private bool isInternal;

        public DateTime Date { get => date; set => date = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public string SourceAccount { get => sourceAccount; set => sourceAccount = value; }
        public string DestinyAccount { get => destinyAccount; set => destinyAccount = value; }
        public bool IsInternal { get => isInternal; set => isInternal = value; }

        public Transaction(DateTime date, decimal amount, string source, string destiny)
        {
            Date = date;
            Amount = amount;
            SourceAccount = source;
            DestinyAccount = destiny;
            IsInternal = true;
        }

        public Transaction(DateTime date, decimal amount, string source, string destiny, bool isInternal)
        {
            Date = date;
            Amount = amount;
            SourceAccount = source;
            DestinyAccount = destiny;
            IsInternal = isInternal;
        }

        
    }
}
