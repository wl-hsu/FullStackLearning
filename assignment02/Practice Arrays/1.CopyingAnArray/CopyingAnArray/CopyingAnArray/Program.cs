int[] arr1 = new int[10];
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = i + 1;
}

int[] copyArr1 = new int[arr1.Length];
for (int i = 0; i < arr1.Length; i++)
{
    copyArr1[i] = arr1[i];
}


foreach  (int i in arr1)
{
    Console.Write(i + " ");

}
Console.WriteLine();
foreach (int i in copyArr1)
{
    Console.Write(i + " ");

}

Console.WriteLine(arr1);