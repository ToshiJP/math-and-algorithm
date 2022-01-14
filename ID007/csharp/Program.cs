using System;

class Program
{
    static void Main(string[] args)
    {
        var inputs = Console.ReadLine().Split(" ");
        var n = int.Parse(inputs[0]);
        var x = int.Parse(inputs[1]);
        var y = int.Parse(inputs[2]);
        var cnt = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % x == 0 || i % y == 0) cnt++;
        }
        Console.WriteLine(cnt);
    }
}
