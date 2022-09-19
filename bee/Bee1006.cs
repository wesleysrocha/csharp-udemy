using System;

public class bee1007
{
    public bee1007()
    {
        double A, B, C, media;

        A = double.Parse(Console.ReadLine());
        A = A * 2;
        B = double.Parse(Console.ReadLine());
        B = B * 3;
        C = double.Parse(Console.ReadLine());
        C = C * 5;

        media = (A + B + C) / 10;
        Console.WriteLine("MEDIA: " + media.ToString("F1"));

    }
}
