// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
//и метод который возводит число A в натуральную степень B. Задание должно быть выполнено в методе. 
//В методе не должно быть вывода в консоль. Не использовать Math.Pow()

bool isParsed1 = int.TryParse(Console.ReadLine(), out int number1);
bool isParsed2 = int.TryParse(Console.ReadLine(), out int number2);
if (!isParsed1 || number1 < 1 || !isParsed2 || number2 < 1)
{
    Console.WriteLine("Incorrect");
}

int count = GetDegreeOfNumber();
Console.WriteLine(count);

int GetDegreeOfNumber()
{
    int count = number1;
    for (int i = 1; i < number2; i++)
    {
        count = count * number1;
    }
    return count;
}