
BankAccount account = new BankAccount();
Console.WriteLine($"Balance is {account.Balance}");

account.Deposit(10000);
account.Withdraw(2000);
Console.WriteLine($"Balance is {account.Balance}");
