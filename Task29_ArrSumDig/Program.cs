int[] array = new int[8];
FillArray(array);

void FillArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);
        if (i==0)
            Console.Write("[ " + array[i] + " , ");
        else if (i >= 1 && i <= size-2)
            Console.Write(array[i] + " , ");
        else if (i == size-1)
            Console.Write(array[i] + " ]");
    }
}
