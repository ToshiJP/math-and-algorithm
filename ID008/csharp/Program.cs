using System;

class Program
{
    static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split(" ");
        var n = int.Parse(inputs[0]);
        var s = int.Parse(inputs[1]);
        var ans = 0;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i + j <= s) ans++;
            }
        }
        Console.WriteLine(ans);
    }
}
