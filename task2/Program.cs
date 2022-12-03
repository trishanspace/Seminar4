// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed || number < 1)
{
    Console.WriteLine("Incorrect");
}

int SumNumber = GetSumNumber(number);
Console.WriteLine(SumNumber);
int GetSumNumber (int number)
{
    int sum = 0;
    while (number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
    return sum;
}