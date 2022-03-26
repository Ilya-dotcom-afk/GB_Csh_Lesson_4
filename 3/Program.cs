// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[20];
Random rand = new Random();
int sumOddPosition = 0;

void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 21);
    }
}
void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
Console.WriteLine();
}

FillArray(array);
PrintArray(array);
for (int i = 0; i < array.Length; i++)
{
    if(i%2 == 0) sumOddPosition += array[i];
}
Console.WriteLine("сумма чисел массива стоящих на нечетной позиции равна " + sumOddPosition);