// : Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

for (int i = 0; i < 10; i++)
{
    int number = new Random().Next(10, 10000000);
    if (number>100)
    {
        
    }
    int n1 = number / 10;
    int n2 = number % 10;
    int n3 = number % 100;
    int result = (n3-n2)/10;
    Console.WriteLine ($"{number}-> вторая цифра {result} ");
    
}

Console.WriteLine ("Enter a number:");
int Value2 = Convert.ToInt32(Console.ReadLine());
// int Length2 = Value2.ToString().Length;
// if (Length2 >= 3) {
// 	while (Value2 > 999)
// 	{
// 		Value2 = Value2 / 10;
// 	}
// 	int result = Value2 % 10;
// 	Console.WriteLine("The third digit is " + result);
// } else {
// 	Console.WriteLine("The number contains less than 3 digits");
// }

