// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

for (int i = 0; i < 20; i++)
{
    int number = new Random().Next(100, 1000);
    int n1 = number / 10;
    int n2 = number % 10;
    int n3 = number % 100;
    int result = (n3-n2)/10;
    Console.WriteLine ($"{number}-> вторая цифра {result} ");
}