// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
collection[index] = new Random().Next(100,999);
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
    int oddNumbersCount = 0;
    int evenNumbersCount = 0;
    int i = 0;
    while (i < count)
    {
        if (array[i]%2 == 0)
        {
          evenNumbersCount++;  
        }
        else
        {
           oddNumbersCount++; 
        }
        i++;
    }

Console.WriteLine("Количество четных чисел равно: " + evenNumbersCount);
Console.WriteLine("Количество нечетных чисел равно: " + oddNumbersCount);

