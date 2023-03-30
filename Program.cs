// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}

int num = ReadInt("Введите первое число ");
int num2 = ReadInt("Введите второе число ");
int num3 = ReadInt("Введите третье число ");

if (num > num2)
{
    if (num > num3)
    {
         Console.WriteLine($"Первое число {num} самое большое");
    }
    else
    {
         Console.WriteLine($"Третье число {num3} самое большое");
    }
}
else if (num3 > num2)
{
    if (num3 > num)
    {
         Console.WriteLine($"Третье число {num3} самое большое");
    }
    else
    {
         Console.WriteLine($"Первое число {num} самое большое");
    }
}
else
{
     Console.WriteLine($"Второе число {num2} самое большое");
}