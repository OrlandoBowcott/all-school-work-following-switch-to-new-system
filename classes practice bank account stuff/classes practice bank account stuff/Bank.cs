public class Bank
{
    private int SortCode;
    private string BankName;
    private BankAccount?[] accounts = new BankAccount?[100];
    private SavingsAccount?[] SavingsAccounts = new SavingsAccount?[100];

    public Bank(int SortCode, string BankName)
    {
        this.SortCode = SortCode;
        this.BankName = BankName;
    }

    public void AddAccount(int AccountNumber, string HolderName, int InitialBalance, int InterestRate, bool IsSavings)
    {
        if (IsSavings)
        {
            SavingsAccount account = new SavingsAccount(InterestRate, AccountNumber, HolderName, InitialBalance);
            for (int i = 0; i < SavingsAccounts.Length; i++)
            {
                if (SavingsAccounts[i] == null)
                {
                    SavingsAccounts[i] = account;
                    return;
                }
                else if (i == 99)
                {
                    Console.WriteLine("No available space for new account.");
                }
            }
        }
        else
        {
            BankAccount account = new BankAccount(AccountNumber, HolderName, InitialBalance);
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    return;
                }
                else if (i == 99)
                {
                    Console.WriteLine("No available space for new account.");
                }
            }
        }
    }
    public void RemoveAccount(int AccountNumber, bool IsSavings)
    {
        if (IsSavings)
        {
            for (int i = 0; i < SavingsAccounts.Length; i++)
            {
                if (SavingsAccounts[i] == null)
                {
                    continue;
                }
                int CurrentAccount = SavingsAccounts[i].GetAccountNumber();
                if (CurrentAccount == AccountNumber)
                {
                    SavingsAccounts[i] = null;
                }
            }
        }
        else
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                {
                    int CurrentAccount = accounts[i].GetAccountNumber();
                    if (CurrentAccount == AccountNumber)
                    {
                        accounts[i] = null;
                    }
                }
            }
        }
    }
    public void deposit(int amount, int accountnumber, bool IsSavings)
    {
        if (IsSavings)
        {
            for (int i = 0; i < SavingsAccounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                int CurrentAccount = SavingsAccounts[i].GetAccountNumber();
                if (CurrentAccount == accountnumber)
                {
                    SavingsAccounts[i].Deposit(amount);
                }
            }
            return;
        }
        for (int i = 0; i < accounts.Length; i++)
        {
            if (accounts[i] == null)
            {
                continue;
            }
            int CurrentAccount = accounts[i].GetAccountNumber();
            if (CurrentAccount == accountnumber)
            {
                accounts[i].Deposit(amount);
            }
        }
    }
    public void withdraw(int amount, int accountnumber, bool IsSavings)
    {
        if (IsSavings)
        {
            for (int i = 0; i < SavingsAccounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                int CurrentAccount = SavingsAccounts[i].GetAccountNumber();
                if (CurrentAccount == accountnumber)
                {
                    SavingsAccounts[i].Withdraw(amount);
                }
            }
            return;
        }
        else
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                int currentAccount = accounts[i].GetAccountNumber();
                if (currentAccount == accountnumber)
                {
                    accounts[i].Withdraw(amount);
                }
            }
        }
    }


}
