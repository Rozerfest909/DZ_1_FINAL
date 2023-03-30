// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}

int num = ReadInt("Введите первое число ");
int num2 = ReadInt("Введите второе число ");

if(num > num2)
{
     Console.WriteLine($"Первое число {num} больше второго {num2}");git push -u origin main
}
else
{
    Console.WriteLine($"Второе число {num2} больше первого {num}");
}