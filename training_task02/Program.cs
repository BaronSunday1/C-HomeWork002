// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int threeN = number % 10;
    System.Console.WriteLine(threeN);
}
else if (number > 999 && number < 10000)
{
    int threeN = number / 10;
    System.Console.WriteLine(threeN % 10);
}
else if (number > 9999 && number < 100000)
{
    int threeN = number / 100;
    System.Console.WriteLine(threeN % 10);
}
else if (number > 99999 && number < 1000000)
{
    int threeN = number / 1000;
    System.Console.WriteLine(threeN % 10);
}
if (number < 99)
{
    System.Console.WriteLine("There is no three-digit.");
}


