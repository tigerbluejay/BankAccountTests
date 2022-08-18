// See https://aka.ms/new-console-template for more information
using MyBankLibrary;

var account = new Account("<name>", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} " +
    $"with {account.Balance} initial balance.");

account.MakeWithdrawal(5, DateTime.Now, "Rent Payment");
account.MakeWithdrawal(5, DateTime.Now, "Coffee");
account.MakeWithdrawal(5, DateTime.Now, "Diet Coke");
account.MakeWithdrawal(5, DateTime.Now, "Pants");
account.MakeWithdrawal(120, DateTime.Now, "Rent Payment");
account.MakeWithdrawal(5, DateTime.Now, "Misc");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);

Console.WriteLine(account.GetAccountHistory());

//// Test for negative balance
//try
//{
//    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
//}
//catch (InvalidOperationException e)
//{
//    Console.WriteLine("Exception caught trying to overdraw");
//    Console.WriteLine(e.ToString());
//}


//// Test that the initial balances must be positive
//Account invalidAccount;
//try
//{
//    invalidAccount = new Account("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    Console.WriteLine("Exception caught creating account with negative balance");
//    Console.WriteLine(e.ToString());
//    return;
//}


