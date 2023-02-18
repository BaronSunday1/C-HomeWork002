// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("There is no three-digit.");
}


