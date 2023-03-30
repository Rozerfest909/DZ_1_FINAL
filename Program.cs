// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int ReadInt(string message) 
{
    Console.Write($"{message} >"); 
    int value = Convert.ToInt32(Console.ReadLine()); 
    return value;
}

int num = ReadInt("Введите число ");
var num2 = 2;

while (num >= num2)
     {
        Console.WriteLine($"Четное число {num2} ");
        num2 = num2 + 2;
     }
