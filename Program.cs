// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int d = 0;

Console.WriteLine("Введите первое число"); //приглашение пользователя ввести информацию 1

int a = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Введите второе число"); //приглашение пользователя ввести информацию 2

int b = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Введите третье число"); //приглашение пользователя ввести информацию 3

int c = Convert.ToInt32( Console.ReadLine());

if (a>b)
{
d = a;
}
else d = b;

if (d>c)
{
    Console.WriteLine("Максимальное число = " + d ); 
}
else 
{
Console.WriteLine("Максимальное число = " + c );
}

