using System;

namespace BankAccountsChallenge
{
    class CheckingAccount:BankAccount {
        private const decimal OVERDRAW_CHARGE = 35.00m;
        public CheckingAccount(string firstname, string lastname, decimal bal)
        :base(firstname,lastname,bal){}
    
        public override void Withdraw(decimal amount){
            // If the account gets overdrawn add and extra charge
            if(amount > Balance){
                amount += OVERDRAW_CHARGE;
            }
                base.Withdraw(amount);
        }
    }
    
}