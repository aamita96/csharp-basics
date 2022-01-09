using System;

namespace BankAccountsChallenge
{
    class SavingsAccount:BankAccount {
        private decimal _interest;
        private int _withdrawlCount = 1;
        private const int WITHDRAWL_LIMIT = 3;
        private const decimal EXTRA_CHARGE = 2.00m;
        public SavingsAccount(string firstname,string lastname,decimal interest,decimal bal)
        :base(firstname,lastname,bal){
            _interest = interest;
        }
        public void ApplyInterest(){
            Balance+= ( Balance * _interest);
        }
        public override void Withdraw(decimal amount){
            if(amount > Balance){
                Console.WriteLine("Attempt to overdraw - Permission Denied!");
            }else{
                if(_withdrawlCount > WITHDRAWL_LIMIT){
                    Console.WriteLine($"More than {WITHDRAWL_LIMIT} withdrawls - extra charge");
                    amount+= EXTRA_CHARGE;
            }
                base.Withdraw(amount);
                _withdrawlCount++;
            }
            
                
        }
        
    }
}