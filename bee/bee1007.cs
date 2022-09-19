using System;

public class bee1007
{
    public bee1007()
    {
        int A, B, C, D, diferenca;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());

        diferenca = A * B - C * D;

        Console.WriteLine("DIFERENCA = " + diferenca);
    }
}
