//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = int.Parse(Console.ReadLine());
int thirdNumber = number % 10;

if(number < 100)
{
     System.Console.WriteLine("третьей цифры нет");
}
else
{
        if(number<1000)
        {
            System.Console.WriteLine($"{thirdNumber}");
        }
        else
        {
            System.Console.WriteLine("не знаю как решить эту задачу");
        }
}
