//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());

if (a==6 || a==7)
{
    System.Console.WriteLine("выходной");
}
else
{
    System.Console.WriteLine("будни");
}
