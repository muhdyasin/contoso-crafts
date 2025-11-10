
namespace BankingTests;

using ClassesLibrary;
public class BasicTests
{
    [Fact]
    public void TrueIsTrue()
    {
        Assert.True(true);
    }

    [Fact]
    public void CanTakeMoreThanYouHave()
    {
        var account = new BankAccount("Scott", 1000);
        //Test for negative balance

        Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw")
        );

    }
    
    [Fact]
    public void NeedMoneyToStart()
    {
        BankAccount invalidAccount;
        //Test for invalid account
        Assert.Throws<ArgumentOutOfRangeException>(
        ()=> invalidAccount = new BankAccount("invalid", -55)

        ); 
    }

}
