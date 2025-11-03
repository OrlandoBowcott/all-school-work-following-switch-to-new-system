using System;

public class BankAccount
{
    private int AccountNumber;
    private string AccountHolderName;
    private float Balance;

    public BankAccount(int accountNumber, string accountHolderName, float initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = initialBalance;
    }

    public void Deposit(float amount)
    {
        if (amount <= 0)
        {
           Console.WriteLine("Deposit amount must be greater than zero.");
        }
        else
        {
            Balance += amount;
        }
           
    }

    public void Withdraw(float amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("invalid withdrawal amount");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("not enough available funds");

        }
        else
        {
            Balance -= amount;
        }
        
    }

    public float GetBalance()
    {
        return Balance;
    }
    public void SetBalance(float newBalance)
    {
        Balance = newBalance;
    }
    public int GetAccountNumber()
    {
        return AccountNumber;
    }
    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolderName}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}
