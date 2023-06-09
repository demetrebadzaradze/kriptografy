using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int num;
        string alfabets = " abcdefghijklmnopqrstuvwxyz";

        char[] alfabet = new char[27];
        string word = "";
        string result = "";

        for (int i = 0; i < alfabet.Length; i++)
        {
            alfabet[i] = alfabets[i];
        }

        Console.WriteLine("enter word");
        word = Convert.ToString(Console.ReadLine());

        Console.WriteLine("enter number");
        num = Convert.ToInt32(Console.ReadLine());

        int[] indexes = new int[word.Length];

        for (int i = 0; i < word.Length; i++)
        {
            indexes[i] = IndexOfC(alfabet, word[i]);
        }

        AddNum(indexes, num);
        
        for (int i = 0; i < word.Length; i++)
        {
            result = result + alfabet[indexes[i]];
        }

        Console.WriteLine(result);
    }

    static int IndexOfC(char[] c, char x)
    {
        for (int i = 0; i < c.Length; i++)
        {
            if (c[i] == x)
            {
                return i;
            }
        }
        return -1;
    }
    static void AddNum(int[] arr, int n)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            bool changed = false;

            if (arr[i] < 27 - n && arr[i] != 0 && changed == false) //-1
            {
                arr[i] = arr[i] + n;
                changed = true;
            }
            if (arr[i] > 27 - n && arr[i] != 0 && changed == false)
            {
                arr[i] = arr[i] - (27 - n) + 1;
                changed = true;
            }
            if (arr[i] == 0 && changed == false)
            {
                arr[i] = 0;
                changed = true;
            }
        }
    }
}

//also you can take stuf out as a method to make code cleaner
