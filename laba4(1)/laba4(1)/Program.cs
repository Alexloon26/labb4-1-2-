using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

public class Element
{
    public int Generation()
    {
        Random rnd = new Random();
        int a = rnd.Next(0, 10);
        return a;
    }
}

public class Array : Element
{
    public int size;
    public int[] arr1;

    public void stvorennya()
    {
        Console.WriteLine("створено масив");
        for (int i = 0; i < size - 1; i++)
        {
            arr1[i] = Generation();

        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = 0; i < arr1.Length; i++)
        {
            sb.Append(arr1[i]);
            if (i < arr1.Length - 1)
            {
                sb.Append(", ");
            }
        }
        sb.Append("]");
        return sb.ToString();
    }
    public void sum(Array otherArr)
    {
        int[] add = new int[size];
        Console.Write("сума:|");
        for (int i = 0; i < size; i++)
        {
            add[i] = arr1[i] + otherArr.arr1[i];
            Console.Write($"{add[i]}|");
        }
        Console.WriteLine();
    }
    public void diff(Array otherArr)
    {
        int[] add = new int[size];
        Console.Write("Рiзниця:|");
        for (int i = 0; i < size; i++)
        {
            add[i] = arr1[i] - otherArr.arr1[i];
            Console.Write($"{add[i]}|");
        }
        Console.WriteLine();
    }
    public void mult(Array otherArr)
    {
        int[] add = new int[size];
        Console.Write("добуток:|");
        for (int i = 0; i < size; i++)
        {
            add[i] = arr1[i] * otherArr.arr1[i];
            Console.Write($"{add[i]}|");
        }
        Console.WriteLine();
    }
    public override bool Equals(object? obj)
    {

        if (obj is Array person) return arr1 == person.arr1;
        return false;
    }


}

class Program
{
    static void Main()
    {
        Array ar1 = new Array();
        Console.Write("ввести розмiрнiсть:");
        int s = int.Parse(Console.ReadLine());
        ar1.size = s;
        ar1.arr1 = new int[s];
        ar1.stvorennya();
        Console.WriteLine(ar1.ToString());
        Array ar2 = new Array();
        ar2.size = s;
        ar2.arr1 = new int[s];
        ar2.stvorennya();
        Console.WriteLine(ar2.ToString());
        ar1.sum(ar2);
        ar1.diff(ar2);
        ar1.mult(ar2);
        bool arrEquals = ar1.Equals(ar2);
        Console.WriteLine(arrEquals);


    }
}