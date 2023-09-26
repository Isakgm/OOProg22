
BankAccount myAccount = new BankAccount("Isak Møller");


Console.WriteLine($"Account holders name : {myAccount.AccountHolder}");

myAccount.Deposit(2000);
Console.WriteLine($"Account balance is : {myAccount.Balance}");

myAccount.Withdraw(1500);
Console.WriteLine($"Account balance is : {myAccount.Balance}");
