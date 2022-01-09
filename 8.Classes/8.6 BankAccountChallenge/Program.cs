using System;

namespace BankAccountsChallenge
{
    class Program{
        static void Main(){
            // Create the Checking Account with initial balance
            CheckingAccount checking = new CheckingAccount("John","Doe",2500.0m);

            // Create the Savings Account with interest  and inital balance 
            SavingsAccount saving = new SavingsAccount("Jane","Doe",0.025m,1000.0m);

            // check the balance
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            // Print the account owner information. Expected output:
            // "Checking owner: John Doe"
            // "Saving owner: Jane Doe"
            Console.WriteLine($"Checking owner: {checking.AccountOwner}");
            Console.WriteLine($"Savings owner: {saving.AccountOwner}");

            // Deposit some money in each account
            checking.Deposit(200.0m);
            saving.Deposit(150.0m);

            // check the balance
            // Expected output should be 2700 and 1150 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            // Make some withdrawls from each account
            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);

            // check the balance
            // Expected output should be 2650 and 1025 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            // Apply the savings interest
            saving.ApplyInterest();

            // Savings balance should now be 1050.63
            Console.WriteLine($"Savings balance is {saving.Balance:C2}"); 

            // More than 3 Savings withdrawls should result in 2.00 charge
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);

            // Savings balance should now be 988.63
            Console.WriteLine($"Savings balance is {saving.Balance:C2}"); 

            // Try to overdraw savings - this should be denied and print message.
            saving.Withdraw(2000.0m);   

            // Try to overdraw checking - should result in extra charge
            checking.Withdraw(3000.0m);

            // Expected output should be -385 and 988.63
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
        }
    }
}