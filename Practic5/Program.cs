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

int [] CopyArray(int[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}
int dimension = 5;
int[] array = InitArray(dimension);
Console.WriteLine(string.Join(", ", array ));
int [] arr = CopyArray(array);
Console.WriteLine(string.Join(", ", arr ));