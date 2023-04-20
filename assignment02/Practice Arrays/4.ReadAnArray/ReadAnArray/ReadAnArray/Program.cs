using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a space separated list of integers: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int[] intArray = Array.ConvertAll(inputArray, int.Parse);
        Console.Write("Enter a k value ");
        string tempk = Console.ReadLine();
        int k = int.Parse(tempk);
        int[] ans = new int[intArray.Length];
        int totalTimeForSum = 0;


        // update K and pre-treat our ans array
        /*  for array 3 2 4 -1 if k == 4 and array length is 4
            totalTimeForSum = k / array length;
            newK = k % array length
         
            -1 3 2 4
            4 -1 3 2
            2 4 -1 3
            3 2 4 -1

            8 8 8 8

            get the (quotient * array element sum)
            assign it to every element in ans

         */
        if (k >= intArray.Length)
        {
            totalTimeForSum = k / intArray.Length;
            k %= intArray.Length;
        }
        if (totalTimeForSum > 0)
        {
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            for (int i = 0; i < totalTimeForSum; i++)
            {
                for (int j = 0; j < ans.Length; j++)
                {
                    ans[j] += sum;
                }
            }


        }


        /*
            use new K to rotate intArray
         */
        rotated(intArray, k);
        /*
            expand our intArray to twice with original element twice
            ex if out intArray is 1 2 3 4 -> 1 2 3 4 1 2 3 4
            we do that due to make sliding windows metod easily
            startWindow = 0 as s , endWindow = k - 1 as e
            ex 1 2 3 4 1 2 3 4
               s   e
                 s   e
                   s   e
                      s  e
            Make intArray twice with original elements twice help us avoid
            calculation when should we make endWindow 0 in order to avoid 
            nullpointerexception in array.
         */
        intArray = expandArray(intArray);
        updateAns(ans, intArray, k);
        foreach(int i in ans)
        {
            Console.Write(i + " ");
        }
        


    }
    static void rotated(int[] intArray, int k)
    {
        int n = intArray.Length;
        k %= n;
        rotatedHelper(intArray, 0, n - k - 1);
        rotatedHelper(intArray, n - k, intArray.Length - 1);
        rotatedHelper(intArray, 0, intArray.Length - 1);
    }

    static void rotatedHelper(int[] n, int i, int j)
    {
        for (int p = i, q = j; p < q; p++, q--)
        {
            int temp = n[p];
            n[p] = n[q];
            n[q] = temp;
        }
    }

    static int[] expandArray(int[] intArray)
    {
        int[] newArray = new int[ 2 * (intArray.Length)];
        for (int i = 0; i < intArray.Length; i++)
        {
            newArray[i] = intArray[i];
        }
        int pointer = 0;
        for (int i = intArray.Length; i < newArray.Length; i++)
        {
            newArray[i] = intArray[pointer];
            pointer++;
        }
        return newArray;
    }

    static void updateAns(int[] ans, int[] intArray, int k)
    {
        int startWindows = 0; 
        int endWindows = k;
        for (int i = 0; i < ans.Length; i++)
        {
            for (int j = startWindows; j < endWindows; j++)
            {
                ans[i] = ans[i] + intArray[j];
            }
            startWindows++;
            endWindows++;
        }
    }


}






