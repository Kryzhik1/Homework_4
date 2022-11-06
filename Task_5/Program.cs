// Найти сумму чисел одномерного массива стоящих на нечетной позиции.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
collection[index] = new Random().Next(1,1000);
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

int[] array = new int[10];
FillArray(array);
PrintArray(array);

    int count = array.Length;
    int sum = 0;
    int position = 0;
    while (position < count)
    {
        if (position%2 != 0)
        {
          sum = sum + array[position];  
        }
       position++; 
    }

Console.WriteLine("Сумма чисел одномерного массива, стоящих на нечетной позиции, равна: ");
Console.WriteLine(sum);

