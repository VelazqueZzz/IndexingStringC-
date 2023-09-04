using System;
using System.Data;

class InfexingStringDemo
{
    static void Main()
    {
        foreach(char s in "Текст")
        {
            Console.Write(s+" ");
        }
        Console.WriteLine();
        for (int k = 0; k < "Текст".Length; k++)
        {
            Console.Write("Текст"[k] + "_");
        }
        Console.WriteLine();
        string A = "Изучаем C#";
        for(int k = 0; k < A.Length; k++)
        {
            Console.Write(A[k]);
        }
        Console.WriteLine();
        showReversed(A);
        Console.WriteLine(A);
        String B = getReversed(A);
        Console.WriteLine(B);

    }
    static String getReversed(String txt)
    {
        String str = "";
        foreach (char s in txt)
        {
            str = s + str;
        }
        return str;
    }
        static void showReversed(String txt)
        {
            for(int k = txt.Length - 1; k >= 0; k--)
            {
                Console.Write(txt[k]);
            }
            Console.WriteLine();
        }
    
}