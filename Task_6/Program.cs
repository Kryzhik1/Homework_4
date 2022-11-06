// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
collection[index] = new Random().Next(1,10);
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

Console.WriteLine("Произведение пар чисел в одномерном массиве равно: ");

void FillArray_1(int[] array_1)
{
  int ProductOfNumbers = 0;
int count =  array.Length;
int position = 0;
while (position<count)
{
  array_1[ProductOfNumbers] = array[position]*array[count - (position+1)];
   position++;
  ProductOfNumbers++;
}
}

void PrintArray_1(int[] array_1)
{
int count = array_1.Length;
int position = 0;
while (position < count/2)
{
    Console.WriteLine(array_1[position]);
    position++;
    }
}
int [] array_1 = new int [10];
FillArray_1(array_1);
PrintArray_1(array_1);



   


