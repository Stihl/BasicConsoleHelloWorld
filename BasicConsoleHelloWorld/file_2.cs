using System;
using System.Collections.Generic; //There by default in VS but needs to be added when using terminal or plain text editors
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleHelloWorld
{
    class file_2
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach(var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
            
        }
        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();

        public file_2(string name, decimal initBalance){
            
            //this.Balance = initBalance; //error anyways....
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initBalance, DateTime.Now, "Initial Balance");

        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdraw(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            report.AppendLine("Date\t\tAmount\tNote");
            foreach(var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }

            return report.ToString();
        }

        
    }
}
