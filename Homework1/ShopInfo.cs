public class ShopInfo
{
    private string ShopName;
    private string TaxNumber;
    private string OwnerName;
    private string CompanyValue;
    public void UserInput()
    {
        Console.Write("Please input Name: ");
        this.ShopName = Console.ReadLine();
        Console.Write("Please input Number: ");
        this.TaxNumber = Console.ReadLine();
        Console.Write("Please input Owner Name: ");
        this.OwnerName = Console.ReadLine();
        Console.Write("Please input Registered Value: ");
        this.CompanyValue = Console.ReadLine();
    }
    public void PrintShopDetail()
    {
        Console.WriteLine("—--------- Shop Information —-----");
        Console.WriteLine("Name: {0}", this.ShopName);
        Console.WriteLine("Number: {0}",this.TaxNumber);
        Console.WriteLine("Owner Name: {0}", this.OwnerName);
        Console.WriteLine("Registered Value: {0}", this.CompanyValue);
        Console.WriteLine("—-----------------------------------------------------");
    }
}