class Program
{
    static int[] Values = new int[3];
    static int Sum;
    static void Main(string[] args)
    {
        Calc CalcSum = new Calc();
        PrintGet3Value(Values);
        PrintSum(Values,CalcSum);
    }
    static void PrintGet3Value(int[] Values)
    {
        Console.Write("Please input number 1: ");
        Values[0] = StringToInt(Console.ReadLine());
        Console.Write("Please input number 2: ");
        Values[1] = StringToInt(Console.ReadLine());
        Console.Write("Please input number 3: ");
        Values[2] = StringToInt(Console.ReadLine());
    }
    static void PrintSum(int[] Values,Calc CalcSum){
        
        Console.WriteLine("Sum: {0}",CalcSum.CalcSum(Values));
    }
    static int StringToInt(string InputValue)
    {
        if (int.TryParse(InputValue, out int number))
        {
            return number;
        }
        else throw new Exception("Please Enter a Number.");
    }
}