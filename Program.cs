// Напишите программу,которая на вход принимает два числа и выдаёт какое большее,а какое меньшее
/*
Console.WriteLine("Введите первое число ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");

int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Первое число больше второго ");
}

else if (num1 < num2)
{
    Console.WriteLine("Второе число больше первого ");
}
*/

//Задача №4 Написать программу которая на вход принимает три числа
//и выдаёт максимальное из этих чисел

/*
Console.WriteLine("Введите первое число ");

 int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");

int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Первое число больше второго ");

}

else if (num1 < num2)
{
    Console.WriteLine("Второе число больше первого ");
}

if(num2 > num3)
{
    Console.WriteLine("Второе число больше Третьего ");

}

else if (num2 < num3)
{
    Console.WriteLine("Третье число больше второго ");

}

*/

//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка.
/*
int a;                             
    Console.WriteLine("введите число: ");
        a = Convert.ToInt32(Console.ReadLine()); 
 
if (a % 2 == 0)
{
    Console.WriteLine("четное число");
           
     }
     else
{
    Console.WriteLine("нечетное");
     } 
   */  

   //Напишите программу, которая на вход принимает число (N),
   //а на выходе показывает все чётные числа от 1 до N.

   int num;

   Console.Write("Введите число ");

   num = Convert.ToInt32(Console.ReadLine());

   if (num % 2 == 0)

    Console.WriteLine("четное число");
else
{
    Console.WriteLine("нечетное");
   }

   {

       Console.Write(num + " ");

       num++;

   }