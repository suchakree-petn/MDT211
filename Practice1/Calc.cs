public class Calc
{
    public int CalcSum(int[] Values)
    {
        int TempValue = 0;
        foreach (int i in Values)
        {
            TempValue += i;
        }
        return TempValue;
    }
}