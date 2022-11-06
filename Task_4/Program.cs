// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
collection[index] = new Random().Next(1,999);
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

int[] array = new int[8];
FillArray(array);
PrintArray(array);

int count = array.Length;
    int twodigitNumbersCount = 0;
    int i = 0;
    while (i < count)
    {
        if (array[i]/100 == 0)
        {
          twodigitNumbersCount++;  
        }
        i++;
    }

Console.WriteLine("Количество элементов из отрезка [10;99] равно: " + twodigitNumbersCount);

