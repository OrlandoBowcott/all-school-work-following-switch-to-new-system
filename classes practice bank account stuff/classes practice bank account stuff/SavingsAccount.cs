public class SavingsAccount
{
    private int interestRate; // in percentage
    private BankAccount bankAccountInfo;

    public SavingsAccount(string accountNumber, string accountHolderName, float initialBalance, int interestRate)
    {
        this.interestRate = interestRate;
        bankAccountInfo = new BankAccount(accountNumber, accountHolderName, initialBalance);
    }

}