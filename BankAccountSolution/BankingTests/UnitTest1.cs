using MyBankLibrary;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void TrueisTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            var account = new Account("Kendra", 10000);
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraft")
                );
        }
        [Fact]
        public void NeedMoneyToStart()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Account("invalid", -55)
                );
        }
    }
}
