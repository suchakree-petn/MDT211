public class MoneyExchange
{
    private double MoneyInput;
    private double Temp_Int_MoneyInput = 0;
    private double Temp_Decimal_MoneyInput = 0;
    private double Thousand = 0;
    private double FiveHundred = 0;
    private double Hundred = 0;
    private double Fifty = 0;
    private double Twenty = 0;
    private double Ten = 0;
    private double Five = 0;
    private double Two = 0;
    private double One = 0;
    private double PointFive = 0;
    private double PointTwoFive = 0;
    public void RecieveMoneyInput()
    {
        Console.Write("Please input your money: ");
        string StringMoneyInput = Console.ReadLine();
        if (double.TryParse(StringMoneyInput, out double Number))
        {
            this.MoneyInput = Number;
        }
        else throw new Exception("Please enter the amount of money.");
    }
    public static double IntSplit(double MoneyInput)
    {
        double Int_MoneyInput = Math.Floor(MoneyInput);
        return Int_MoneyInput;
    }
    public static double DecimalSplit(double MoneyInput)
    {
        double Decimal_MoneyInput = MoneyInput - Math.Floor(MoneyInput);
        if (Decimal_MoneyInput % 0.25 != 0)
        {
            throw new Exception("You can only exchange 25 and 50 stang coin. Please enter .25, .50 or .75.");
        }
        return Decimal_MoneyInput;
    }
    public void ExchangeMoney()
    {
        double Int_MoneyInput = IntSplit(MoneyInput);
        double Decimal_MoneyInput = DecimalSplit(MoneyInput);
        Temp_Int_MoneyInput += Int_MoneyInput;
        Temp_Decimal_MoneyInput += Decimal_MoneyInput;
        if (Temp_Int_MoneyInput >= 1000)
        {
            Thousand = ThousandCount(Temp_Int_MoneyInput);
            Temp_Int_MoneyInput -= 1000 * Thousand;
        }
        if (Temp_Int_MoneyInput < 1000 && Temp_Int_MoneyInput >= 500)
        {
            FiveHundred = FiveHundredCount(Temp_Int_MoneyInput);
            Temp_Int_MoneyInput -= 500 * FiveHundred;
        }
        if (Temp_Int_MoneyInput < 500 && Temp_Int_MoneyInput >= 100)
        {
            Hundred = HundredCount(Temp_Int_MoneyInput);
            Temp_Int_MoneyInput -= 100 * Hundred;
        }
        if (Temp_Int_MoneyInput < 100 && Temp_Int_MoneyInput >= 50)
        {
            Fifty = FiftyCount(Temp_Int_MoneyInput);
            Temp_Int_MoneyInput -= 50 * Fifty;
        }
        if (Temp_Int_MoneyInput < 50 && Temp_Int_MoneyInput >= 20)
        {
            Twenty = TwentyCount(Temp_Int_MoneyInput);
            Temp_Int_MoneyInput = Temp_Int_MoneyInput - 20 * Twenty;
        }
        if (Temp_Int_MoneyInput < 20 && Temp_Int_MoneyInput >= 10)
        {
            Ten = TenCount(Temp_Int_MoneyInput);
            Temp_Int_MoneyInput = Temp_Int_MoneyInput - 10 * Ten;
        }
        if (Temp_Int_MoneyInput < 10 && Temp_Int_MoneyInput >= 5)
        {
            Five = FiveCount(Temp_Int_MoneyInput);
            Temp_Int_MoneyInput = Temp_Int_MoneyInput - 5 * Five;
        }
        if (Temp_Int_MoneyInput < 5 && Temp_Int_MoneyInput >= 2)
        {
            Two = TwoCount(Temp_Int_MoneyInput);
            Temp_Int_MoneyInput = Temp_Int_MoneyInput - 2 * Two;
        }
        if (Temp_Int_MoneyInput == 1)
        {
            One = 1;
        }
        if (Temp_Decimal_MoneyInput != 0)
        {
            if (Temp_Decimal_MoneyInput >= 0.5)
            {
                PointFive = 1;
                Temp_Decimal_MoneyInput -= 0.5;
            }
            if (Temp_Decimal_MoneyInput == 0.25)
            {
                PointTwoFive = 1;
            }
        }

    }
    public static double ThousandCount(double Temp_Int_MoneyInput)
    {
        int count = 0;
        for (int i = 1000; i <= Temp_Int_MoneyInput; i += 1000)
        {
            count++;
        }
        return count;
    }
    public static int FiveHundredCount(double Temp_Int_MoneyInput)
    {
        int count = 0;
        for (int i = 500; i <= Temp_Int_MoneyInput; i += 500)
        {
            count++;
        }
        return count;
    }
    public static int HundredCount(double Temp_Int_MoneyInput)
    {
        int count = 0;
        for (int i = 100; i <= Temp_Int_MoneyInput; i += 100)
        {
            count++;
        }
        return count;
    }
    public static int FiftyCount(double Temp_Int_MoneyInput)
    {
        int count = 0;
        for (int i = 50; i <= Temp_Int_MoneyInput; i += 50)
        {
            count++;
        }
        return count;
    }
    public static int TwentyCount(double Temp_Int_MoneyInput)
    {
        int count = 0;
        for (int i = 20; i <= Temp_Int_MoneyInput; i += 20)
        {
            count++;
        }
        return count;
    }
    public static int TenCount(double Temp_Int_MoneyInput)
    {
        int count = 0;
        for (int i = 10; i <= Temp_Int_MoneyInput; i += 10)
        {
            count++;
        }
        return count;
    }
    public static int FiveCount(double Temp_Int_MoneyInput)
    {
        int count = 0;
        for (int i = 5; i <= Temp_Int_MoneyInput; i += 5)
        {
            count++;
        }
        return count;
    }
    public static int TwoCount(double Temp_Int_MoneyInput)
    {
        int count = 0;
        for (int i = 2; i <= Temp_Int_MoneyInput; i += 2)
        {
            count++;
        }
        return count;
    }
    public void PrintExchangeMoney()
    {
        Console.WriteLine("1000: {0}", Thousand);
        Console.WriteLine("500: {0}", FiveHundred);
        Console.WriteLine("100: {0}", Hundred);
        Console.WriteLine("50: {0}", Fifty);
        Console.WriteLine("20: {0}", Twenty);
        Console.WriteLine("10: {0}", Ten);
        Console.WriteLine("5: {0}", Five);
        Console.WriteLine("2: {0}", Two);
        Console.WriteLine("1: {0}", One);
        Console.WriteLine(".50: {0}", PointFive);
        Console.WriteLine(".25: {0}", PointTwoFive);
    }
}