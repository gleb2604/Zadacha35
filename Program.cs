/* Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange);
    }
    return array;
}

const int SIZE = 123;
const int LEFT = 0;
const int RIGHT = 151;

int[] massive = GetRandomArray(SIZE, LEFT, RIGHT);
Console.WriteLine(string.Join(", ", massive));


// Количество элементов массива, значения которых лежат в отрезке от 10 до 99:
int Addition(int[] array)
{
    int num = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] >= 10 && massive[i] <= 99) num += 1;
    }
    return num;
}

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке от 10 до 99: {Addition(array: massive)}");