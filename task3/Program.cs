// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random random = new Random();
int[] Array = GetArrayNubers();
Console.Write(Array);

int[] GetArrayNubers()
{
    int[] numbers = new int[8];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(0, 9);
    }
    return numbers;
}