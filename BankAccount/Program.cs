using System;

BankAccount account = new("123-456", "홍길동");
Console.WriteLine($"계좌번호: {account.AccountNumber}\n예금주: {account.OwnerName}");
Console.WriteLine($"잔액: {account.Balance}원");
Console.WriteLine($"--- 50000원 입금 ---");
account.Deposit(50000);
Console.WriteLine($"잔액: {account.Balance}원");
Console.WriteLine("--- 20000원 출금 ---");
account.Withdraw(20000);
Console.WriteLine($"잔액: {account.Balance}원");
Console.WriteLine("--- 100000원 출금 시도 ---");
account.Withdraw(100000);
Console.WriteLine($"잔액: {account.Balance}원");