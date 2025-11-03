using System;

public class Bank 
{
	private int SortCode;
	private string BankName;
	private BankAccount[] accounts = new BankAccount[100]; 

	public Bank(int SortCode, string BankName)
	{
		this.SortCode = SortCode;
		this.BankName = BankName;
	}

	public void AddAccount(BankAccount account)
	{
		try
		{
			for (int i = 0; i < accounts.Length; i++)
			{
				if (accounts[i] == null)
				{
					accounts[i] = account;
					return;
				}
			}
		}
		catch
		{
			Console.WriteLine("Unable to add account.");
        }


    }
	public void RemoveAccount(int AccountNumber)
	{
		for (int i = 0; i < accounts.Length; i++)
		{
			int CurrentAccount = accounts[i].GetAccountNumber();
            if (CurrentAccount == AccountNumber)
            {
                accounts[i] = null;
            }
        }
    }


}
