public class Program
{
    static void Main(string[] args)
    {
        ShopInfo ShopDetail = new ShopInfo();
        ShopDetail.UserInput();
        ShopDetail.PrintShopDetail();
        MoneyExchange CashExchange = new MoneyExchange();
        CashExchange.RecieveMoneyInput();
        CashExchange.ExchangeMoney();
        CashExchange.PrintExchangeMoney();
    } 
}