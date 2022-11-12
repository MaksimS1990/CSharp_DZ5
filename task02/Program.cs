// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Программа создает массив и выводит сумму его элементов, находящихся на нечетных позициях");
int length = int.Parse(Console.ReadLine()!);
int[] array = new int [length];
int count = 0;
RandomArray(length);
Console.WriteLine("Длина Вашего массива: " + length);
NumberOfEvenPosotions(array);
PrintEvenPosotions(array);
Console.WriteLine($" - {count} сумма элементов, стоящих на нечетных позициях");


int[] RandomArray(int length)                // Функция заполнения массива в случайном порядке 
{ 
 for (int i = 0; i < array.Length; i++) 
 { 
 array[i] = new Random().Next(0, 100);
 }
 return array;
}

int NumberOfEvenPosotions(int[] array)         // считаем сумму чисел стоящих на нечетных позициях в массиве
{
for (int i = 0; i < array.Length; i+=2)
    count = count + array [i];
return count;
}

void PrintEvenPosotions(int [] array)          // функция вывода результата
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
};