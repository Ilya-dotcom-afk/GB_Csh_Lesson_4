// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
int number = 0;
Random rand = new Random();
void FillArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(1, 1000);
    }
}
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    if(array[i] >= 10 && array[i] <= 99)
    {
        number++;
    }
}
Console.WriteLine("количество элементов из отрезка [10,99] равно " + number);

