public class SavingsAccount : BankAccount
{
    private float interestRate; 

    public SavingsAccount(float ir, long AN, string AHN, int IB) : base(AN, AHN, IB)
    {
        interestRate = ir;
    }

    public void ApplyInterest(int YearsPassed)
    {
        float CurrentBalance = GetBalance();
        for (int i = 0; i < YearsPassed; i++)
        {
            CurrentBalance = CurrentBalance + (CurrentBalance * (interestRate / 100));
        }
        SetBalance(CurrentBalance);
    }


}