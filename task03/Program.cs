//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Программа находит разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("Введите количесво элементов в массиве: ");
int length = int.Parse(Console.ReadLine()!);
double[] array = new double [length];
GetArray(length);
Console.WriteLine("Длина Вашего массива: " + length);
GetMaxDigits(array);
double max = GetMaxDigits(array);
Console.WriteLine("Максимальное знасение в массиве " + max);
GetMinDigits(array);
double min = GetMinDigits(array);
Console.WriteLine("Минимальное значение в массиве " + min);
double result = max - min;
PrintEvenPosotions(array);
Console.WriteLine($" - {result} разница между максимальным и минимальным элементами массива!");


double[] GetArray(int length)                // Функция заполнения массива в случайном порядке 
{
 for (int i = 0; i < array.Length; i++) 
 { 
 array[i] = double.Parse(Console.ReadLine()!);
 }
 return array;
}

double GetMaxDigits(double[] array)          // Функция нахождения максимального элемента числа
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
}

double GetMinDigits(double[] array)          // Функция нахождения минамального элемента числа
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        {
           if (array[i] < min) min = array[i];
        }
        return min;
}

void PrintEvenPosotions(double[] array)                // функция вывода результата
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}