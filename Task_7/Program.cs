// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
double Max( double arg1, double arg2, double arg3 )
{
    double result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}//                  0     1     2    3      4      5     6     7      8            
double [] array = {1.25, 3.76, 8.38, 9.37, 12.34, 24.54, 4.67, 9.48, 29.84};

double max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]));  

Console.WriteLine("max:  " +max);

double Min( double arg1, double arg2, double arg3 )
{
    double result = arg1;
    if (arg2< result) result = arg2;
    if (arg3< result) result = arg3;
    return result;
}      
double min = Min(
    Min(array[0], array[1], array[2]), 
    Min(array[3], array[4], array[5]), 
    Min(array[6], array[7], array[8]));  

Console.WriteLine("min  " +min);
 Console.WriteLine("Разница максимального и минимального:  "+(max - min));













