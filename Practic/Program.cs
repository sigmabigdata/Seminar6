int[] InitArray(int dimention)


{
    int[] result = new int[dimention];
    Random rnd = new Random();

    for (int i = 0; i < dimention; i++)
    {
        result[i] = rnd.Next(1,10);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] ReversArray(int[] array)
{
    int[] result = new int[array.Length];
    int count = 0;

    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] =  array[i];
        count++;
    }

    return result;
}

int[] startArray = InitArray(10);
PrintArray(startArray);

int[] resultArray = ReversArray(startArray);
PrintArray(resultArray);

int[] arrStart = Enumerable.Range(1, 10).ToArray();
PrintArray(arrStart);

int[] arr = Enumerable.Range(1, 10).ToArray();
PrintArray(arr);

Array.Reverse(arr);
arr.Reverse();

