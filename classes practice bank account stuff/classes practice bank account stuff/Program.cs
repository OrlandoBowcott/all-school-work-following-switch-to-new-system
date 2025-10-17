namespace classes_practice_bank_account_stuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new bank account
            BankAccount account = new BankAccount("123456789", "John Doe", 1000);

            // Display initial account information
            Console.WriteLine("Initial Account Information:");
            account.DisplayAccountInfo();

            // Perform a deposit
            Console.WriteLine("\nDepositing $500...");
            account.Deposit(500);
            account.DisplayAccountInfo();

            // Perform a withdrawal
            Console.WriteLine("\nWithdrawing $300...");
            account.Withdraw(300);
            account.DisplayAccountInfo();

            // Attempt an invalid withdrawal
            Console.WriteLine("\nAttempting to withdraw $2000...");
            account.Withdraw(2000);
            account.DisplayAccountInfo();

            // Attempt an invalid deposit
            Console.WriteLine("\nAttempting to deposit $0...");
            account.Deposit(0);
            account.DisplayAccountInfo();
        }
    }
}
