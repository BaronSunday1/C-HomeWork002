// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Enter the day number of the week: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 5)
{
    System.Console.WriteLine("No. This is a work day.");
}
else if (number <= 7)
{
     System.Console.WriteLine("Yes. This day is a day of.");
}
else 
{
    System.Console.WriteLine("It's not the day of the week.");
}
