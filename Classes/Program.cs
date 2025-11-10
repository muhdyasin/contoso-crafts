// See https://aka.ms/new-console-template for more information

using ClassesLibrary;


var account = new BankAccount("Scott", 1000);

Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");


account.MakeDeposit(50, DateTime.Now, "Friend paid me back");
account.MakeWithdrawal(5, DateTime.Now, "Shoes");
account.MakeWithdrawal(5, DateTime.Now, "Backpack");
account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
account.MakeWithdrawal(7, DateTime.Now, "Books");
account.MakeWithdrawal(8, DateTime.Now, "Pants");

Console.WriteLine(account.GetAccountHistory());

