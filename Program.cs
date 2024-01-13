// Console.Clear();

// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine(n + 10);

// ЗАДАНИЕ 1 ----------------------------------------------------------------------

// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 => yes
// a = 2, b = 10 => no
// a = 9, b = -3 => yes
// a = -3, b = 9 => no

// Console.Clear();
// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите число:");
// int b = Convert.ToInt32 (Console.ReadLine());

// if (b * b == a)
//     Console.WriteLine("yes");
// else 
//     Console.WriteLine("no");    

// ЗАДАНИЕ 2 ------------------------------------------------------------------

/* Console.Clear();
Console.WriteLine("Введите число:");
int n = Convert.ToInt32 (Console.ReadLine());

int i = n * (-1);
while (i <= n)
{
    Console.Write(i);
	Console.Write(' ');
    i = i + 1;
}
*/


/* Альтернативное написание: 

Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = n * (-1); //Создаем счетчик для вывода отрицательного n и делаем цикл, чтобы дойти от -n до n и выводим это все на экран.
while (i <= n)
{
    Console.Write(i + " ");
    i += 1;
}
*/

// ЗАДАНИЕ 3 -----------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17


// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int n1 = n / 100;
// int n3 = n % 10; // % отобразит остаток от деления

// Console.WriteLine(n1 + n3);