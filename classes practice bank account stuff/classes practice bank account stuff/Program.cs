using System.Security.Principal;

namespace classes_practice_bank_account_stuff
{
    internal class Program
    {
        static void TestBankAccountClass()
        {

            BankAccount account = new BankAccount(123456789, "John Doe", 1000);


            Console.WriteLine("Initial Account Information:");
            account.DisplayAccountInfo();


            Console.WriteLine("\nDepositing $500...");
            account.Deposit(500);
            account.DisplayAccountInfo();


            Console.WriteLine("\nWithdrawing $300...");
            account.Withdraw(300);
            account.DisplayAccountInfo();


            Console.WriteLine("\nAttempting to withdraw $2000...");
            account.Withdraw(2000);
            account.DisplayAccountInfo();


            Console.WriteLine("\nAttempting to deposit $0...");
            account.Deposit(0);
            account.DisplayAccountInfo();
        }
        static void TestSavingsAccountClass()
        {
            SavingsAccount NewSavingsAccount = new SavingsAccount(2.0f, 987654321, "Jane Smith", 2000);

            Console.WriteLine("\nInitial Account Information:");
            NewSavingsAccount.DisplayAccountInfo();


            Console.WriteLine("\nDepositing $500...");
            NewSavingsAccount.Deposit(500);
            NewSavingsAccount.DisplayAccountInfo();


            Console.WriteLine("\nWithdrawing $300...");
            NewSavingsAccount.Withdraw(300);
            NewSavingsAccount.DisplayAccountInfo();


            Console.WriteLine("\nAttempting to withdraw $2000...");
            NewSavingsAccount.Withdraw(2000);
            NewSavingsAccount.DisplayAccountInfo();


            Console.WriteLine("\nAttempting to deposit $0...");
            NewSavingsAccount.Deposit(0);
            NewSavingsAccount.DisplayAccountInfo();

            Console.WriteLine("\nApplying interest for 3 years...");
            NewSavingsAccount.ApplyInterest(3);
            NewSavingsAccount.DisplayAccountInfo();


        }
        static void Main()
        {
            TestBankAccountClass();
            TestSavingsAccountClass();
        }
    }
}
