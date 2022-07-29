// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

String PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start +" "+ PrintNumbers(start + 1,end));

}
Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());


Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers (m,n));

    if (n > m) 
    {
       Console.WriteLine($"Сумма = {n+m}"); 
       n++;
       return;
    }
   
  
  
 

// int start =1;
// while (start<=n)
// {
//     Console.Write($"{start++}");
// }
// for (int i = 0 ; i < n ; i++)
// {
//     Console.Write($"{i} ");
// }
// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.