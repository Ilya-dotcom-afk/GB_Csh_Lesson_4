// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Random rand = new Random();
int[] array = new int[10];
int even = 0; // коллчиство чётных чисел
int odd = 0; // колличество нечётных чисел
void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] arr)
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
    if (array[i]%2 == 0) even ++;
    else odd ++;
}
Console.WriteLine("колличество чётных элементов массива равно " + even);
Console.WriteLine("колличество нечётных элементов массива равно " + odd);

