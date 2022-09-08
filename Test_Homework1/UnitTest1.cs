namespace Test_Homework1;

public class UnitTest1
{
    [Fact]
    public void TestIntSplit()
    {
        double IntMoney = MoneyExchange.IntSplit(5210.25);
        Assert.Equal(IntMoney,5210);
    }
    
    [Fact]
    public void TestDecimalSplit()
    {
        double DecimalMoney = MoneyExchange.DecimalSplit(5210.25);
        Assert.Equal(DecimalMoney,0.25);
    }
    [Fact]
    public void TestThousandCount()
    {
        double Count = MoneyExchange.ThousandCount(7654.50);
        Assert.Equal(Count,7);
    }
    [Fact]
    public void TestFiveHundredCount()
    {
        double Count = MoneyExchange.FiveHundredCount(7654.50);
        Assert.Equal(Count,15);
    }
    [Fact]
    public void TestHundredCount()
    {
        double Count = MoneyExchange.HundredCount(7654.50);
        Assert.Equal(Count,76);
    }
    [Fact]
    public void TestFiftyCount()
    {
        double Count = MoneyExchange.FiftyCount(7654.50);
        Assert.Equal(Count,153);
    }
    [Fact]
    public void TestTwentyCount()
    {
        double Count = MoneyExchange.TwentyCount(7654.50);
        Assert.Equal(Count,382);
    }
    [Fact]
    public void TestTenCount()
    {
        double Count = MoneyExchange.TenCount(7654.50);
        Assert.Equal(Count,765);
    }
    [Fact]
    public void TestFiveCount()
    {
        double Count = MoneyExchange.FiveCount(7654.50);
        Assert.Equal(Count,1530);
    }
    [Fact]
    public void TestTwoCount()
    {
        double Count = MoneyExchange.TwoCount(7654.50);
        Assert.Equal(Count,3827);
    }
}