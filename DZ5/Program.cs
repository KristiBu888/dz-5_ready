// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
int evenNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(99, 1000);
    Console.WriteLine(array[i] + " ");

    if (array[i] % 2 == 0)
    {
        evenNumbers = evenNumbers + 1;
    }
    else
    {
        continue;
    }
}
System.Console.WriteLine($"Kоличество чётных чисел в массиве = {evenNumbers}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12]-> 19
[-4, -6, 89, 6]-> 0

int[] array = new int[5];
int sumNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.WriteLine(array[i] + " ");

    if (array[i] % 2 != 0)
    {
        sumNumbers += array[i];
    }
    else
    {
        continue;
    }
}
System.Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях = {sumNumbers}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[5];
double minNumber = array[0];
double maxNumber = array[0];
double diffBetwNumbers = 0;
for (int i = 0; i < array.Length; i++)
{
    Random x = new Random();
    double r = Convert.ToDouble(x.Next(0, 100) / 100.00);
    array[i] = new Random().Next(0, 100) * r;
    Console.WriteLine(array[i] + " ");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < minNumber)
    {
        minNumber = array[i];
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
}
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива {maxNumber} - {minNumber} = {diffBetwNumbers = maxNumber - minNumber}");
