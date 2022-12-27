//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = int.Parse(Console.ReadLine());

if(number < 100)
{
     System.Console.WriteLine("третьей цифры нет");
     return;
}
else
while(number > 999)
{
    number = number / 10;
}

 System.Console.WriteLine(number % 10);