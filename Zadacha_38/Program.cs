/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

float[] GetArray(int length)
{
    float[] arr = new float[length];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(0, 100);
    }
    return arr;
}

void PrintArray(float[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

(float, float) GetMinAndMax(float[] arr)
{
    float min = arr[0];
    float max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return (min, max);
}

Console.WriteLine("Insert massive length:");
int length = int.Parse(Console.ReadLine());

float[] arr = GetArray(length);
PrintArray(arr);

(float min, float max) = GetMinAndMax(arr);
Console.WriteLine();
Console.WriteLine($"The difference between maximal and minimal is {max - min}");