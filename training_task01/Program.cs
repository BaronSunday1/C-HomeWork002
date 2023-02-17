// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int secondN = number / 10;

    System.Console.WriteLine(secondN % 10);
}
else
{
    System.Console.WriteLine("An incorrect number was entered. Enter a three-digit number.");
}