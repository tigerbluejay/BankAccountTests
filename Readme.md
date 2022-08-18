# BankAccountTests

This project builds on the existing Bank Account Project, referenced here: <a href="https://github.com/tigerbluejay/BankAccount">tigerbluejay/BankAccount: Simple Bank Account Demonstrating Classes and Objects, Exception Handling and Basic OOP (github.com)</a>

The project is essentially the same except Class Libraries have been moved to a separate Class Library Project, which now has a reference to Bank Account Project.

There are some minor changes like more calls to the MakeWithrawal() function and a new xUnit Test Project with 3 Tests to demonstrate how tests work.

The first Asserts.True(true) to make sure tests are working and the the other two tests Assert that exceptions are thrown when attempting to overdraft and make a deposit with a negative number.
