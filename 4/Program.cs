// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("Введите колличество элементов в массиве");
int n1 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n1];
int n2 = n1/2;
int[] newArray = new int[n2];
Random rand = new Random();

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1, 10);
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

for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length - i - 1];
}
PrintArray(newArray);