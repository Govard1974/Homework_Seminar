
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

/*

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

int maxNumber = Math.Max(num1, num2);

Console.WriteLine($"max = {maxNumber}");

*/

// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

/*

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = Math.Max(Math.Max (num1, num2), num3);

Console.WriteLine($"max = {maxNumber}");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

/*

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Yes!");
}

else
{
    Console.WriteLine("NO!!!");
}   

*/


//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
/*

Console.WriteLine ("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());


Console.Write("Четные числа от 1 до N: ");
for (int i = 1; i<= N; i++)

 if (i % 2 == 0)
 {
    Console.Write(i + " ");
 }
*/
