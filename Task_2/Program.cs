
// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
collection[index] = new Random().Next(0,10);
index++;
    }
}
void PrintArray(int[] array)
{
int count = array.Length;
int position = 0;
while (position < count)
{
    Console.WriteLine(array[position]);
    position++;
}
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);

    int count = array.Length;
    int sum = 0;
    for (int position = 0; position < count; position++)
    sum = sum + array[position];

Console.WriteLine("Сумма элементов массива равна: ");
Console.WriteLine(sum);





