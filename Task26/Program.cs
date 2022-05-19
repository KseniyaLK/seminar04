// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
//int n = int.Parse(Console.ReadLine());

// int FindNumV (int num)
// {

//     int div = 1;
//     int count = 0;
//        while (num > div)
//        {
//            div = div *10;
//          count++;
//        }
// }
// return CountdownEvent;

 
// Console.WriteLine($"{FindNumV}");

int num = int.Parse(Console.ReadLine());

int count =0;
while (num != 0)
{

    num = num /10 ;
    count++;
}

Console.WriteLine(count);
