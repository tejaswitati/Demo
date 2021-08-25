using System;
class Program
{
    static void Main()
    {
        int[] Numbers = new int[3];
        Numbers[0] = 1001;
        Numbers[1] = 1002;
        Numbers[2] = 1003;

        //ParamsMethod(Numbers);
        ParamsMethod(10, 20, 30, 50);
    }

    static void ParamsMethod(params int[] numbers)
    {
        Console.WriteLine("Number of elements {0}", numbers.Length);

        foreach (int n in numbers)
            Console.WriteLine(n);
    }
}