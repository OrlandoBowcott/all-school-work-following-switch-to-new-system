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


	
}
