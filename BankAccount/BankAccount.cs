using System;

class BankAccount
{
    private int _balance = 0;

    public string AccountNumber { get; }
    public string OwnerName { get; set; }
    public int Balance 
    {
        get { return _balance; }
        private set
        {
            _balance = value;
            if (_balance < 0) _balance = 0;
        }
    }

    public BankAccount(string accountNumber, string ownerName)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(int amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("출금 성공: False");
        }

        else
        {
            Balance -= amount;
            Console.WriteLine("출금 성공: True");
        }
    }
}