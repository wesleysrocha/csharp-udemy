using System;

public class Class1
{
	public Class1()
	{
        //1
        //int numero = int.Parse(Console.ReadLine());
        //int i;
        //int[] arr = new int[numero];
        //int[] numeroParCrescente = new int[numero];
        //int[] numeroImparDecrescente = new int[numero];


        //for (i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());

        //    numeroParCrescente = arr.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
        //    numeroImparDecrescente = arr.Where(x => x % 2 != 0).OrderByDescending(x => x).ToArray();
        //}

        //Console.Write("PAR ");
        //foreach (var item in numeroParCrescente)
        //{

        //    Console.Write(item +" ");
        //}

        //Console.Write("IMPAR ");
        //foreach (var item in numeroImparDecrescente)
        //{
        //    Console.Write(item + " ");
        //}






        //2
        int numero = int.Parse(Console.ReadLine());
        int[] arr = new int[numero];
        for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Vetor ");
        foreach (var item in arr.Where(x => x % 2 == 0).OrderBy(x => x)) Console.WriteLine(item);
        foreach (var item in arr.Where(x => x % 2 != 0).OrderByDescending(x => x)) Console.WriteLine(item);
    }
}
