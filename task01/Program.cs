// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int length = int.Parse(Console.ReadLine()!);
int[] array = new int [length];
int count = 0;
RandomArray(length);
Console.WriteLine("Ваш массив: " + length);
NumberOfEvenDigits(array);
PrintArray(array);
Console.WriteLine($" - {count} чётных");

int[] RandomArray(int length)                       // Функция заполнения массива в случайном порядке 
{ 
 for (int i = 0; i < array.Length; i++) 
 { 
 array[i] = new Random().Next(100, 1000);
 }
 return array;
} 

int NumberOfEvenDigits(int[] array)
{
for (int i = 0; i < array.Length; i++)              // считаем количество четных чисел в массиве
    if (array[i] % 2 == 0){
    count++;
    }
return count;
}

void PrintArray(int [] array)                       // функция вывода результата
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}