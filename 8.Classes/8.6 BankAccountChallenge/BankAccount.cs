using System;

namespace BankAccountsChallenge
{
    class BankAccount {
        private string _firstName;
        private string _lastName;
        public BankAccount(string firstname, string lastname, decimal bal = 0.0m){
            _firstName = firstname;
            _lastName = lastname;
            Balance = bal;
        }
        public decimal Balance {
            get;set;
        }

        public string AccountOwner{
            get => $"{_firstName} {_lastName}";
        }

        public void Deposit(decimal amount){
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount){
            Balance-= amount;
        }
    }
}