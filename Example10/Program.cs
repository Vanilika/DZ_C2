//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
int number = int.Parse(Console.ReadLine());

int secondNumber = number /10 % 10;

System.Console.WriteLine($"{secondNumber}");
