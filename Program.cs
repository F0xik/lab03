﻿Console.WriteLine("На 3");
Console.Write("Введите a: "); double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: "); double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Pow(a - b,3));
Console.WriteLine(Math.Pow(a + b,3));
Console.WriteLine(Math.Pow(a,3) + Math.Pow(b,3));
Console.WriteLine(Math.Pow(a,3) - Math.Pow(b,3));
Console.WriteLine(Math.Pow(a,2) - Math.Pow(b,2));
Console.WriteLine(Math.Pow(a - b,2));
Console.WriteLine(Math.Pow(a + b,2));
Console.WriteLine("\n");
Console.WriteLine("На 4");
Console.Write("Введите a: "); 
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: "); 
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c: ");
double c1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Convert.ToInt32(((Math.Pow(a1, 2) - 4 * b1 * c1)) / (a1 - Math.Pow(a1, 0.5) - Math.Pow(a1, c1)) - Math.Pow((a1 * b1 * c1), 3) / (Math.Pow(a1, 2)) - 2 * a1 * b1 + Math.Pow(b1, 2)));