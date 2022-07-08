/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int length)
{
    int[] array = new int[length];
    Random randomizer = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomizer.Next(-10, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void GetUnevenSum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
    }
    Console.WriteLine(result);
}

Console.WriteLine("Insert massive length:");
int length = int.Parse(Console.ReadLine());

int[] array = GetArray(length);
PrintArray(array);
Console.WriteLine();
GetUnevenSum(array);