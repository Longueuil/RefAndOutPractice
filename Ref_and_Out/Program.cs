class MainClass
{
    public static void Main(string[] args)
    {
        // ref example
        int refNum = 16;

        RefClass refClass = new RefClass();

        Console.WriteLine($"Example of using ref multiplied by 2," +
            $" where entered value = :{refNum} " +
            $"and result = :{refClass.MultiplyBy2(ref refNum)}");

        // out example
        int a = 15;
        int b = 12;
        int abSum;
        int abDifference;
        OutClass outClass = new OutClass();
        if(outClass.CalculateSumAndDifference(a,b,out abSum, out abDifference))
            {
            Console.WriteLine("out example");
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"a + b = {abSum}");
            Console.WriteLine($"a-b/difference between a and b = {abDifference}");
            }
        
    }
}

class RefClass
{
   public int MultiplyBy2(ref int x)
    {
        x = x *2;
        return x;
    }
}

class OutClass
{
    public bool CalculateSumAndDifference(int a, int b, out int sum, out int difference)
    {
        sum = a + b;
        difference = a - b;
        return true;
    }
}