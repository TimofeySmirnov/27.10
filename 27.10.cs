﻿////34.4
//Console.WriteLine("Введите очередное число");
//double n = Convert.ToDouble(Console.ReadLine());
//double z, x, c;
//z = 0;
//x = 0;
//c = 1;
//for (int i = 1; i <= n; i++)
//{
//   z = z + Math.Cos(i);
//    x = x + Math.Sin(i);
//    c = c * (z / x);
//}
//Console.WriteLine($"Выражение равно ={c}");
////24№20
//double a, b, c, m, n;
//Console.WriteLine("Введите значение a:");
//a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите значение b:");
//b = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите значение c:");
//c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите значение точки m:");
//m = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Введите значение точки n:");
//n = Convert.ToDouble(Console.ReadLine());
//double y = a * m * m + b * m + c;
//if (y == n)
//{
//    Console.WriteLine($"График проходит через точку ({m}, {n}).");
//}
//else
//{
//    Console.WriteLine($"График НЕ проходит через точку ({m}, {n}).");
//}
////21.25
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double z = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double x = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин первого прямоугольного паралепипеда");
//double c = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qz = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qx = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("введите одну из величин второго прямоугольного паралепипеда");
//double qc = Convert.ToDouble(Console.ReadLine());
//double q = 0;
//double y = 0;
//q += z * x * c;
//y += qz * qx * qc;
//if (q > y)
//    Console.WriteLine("первый паралепипед больше");
//else
//    Console.WriteLine("второй паралепипед больше");
//34.11
//double c , z;
//c = 1 + Math.Sin(0.1);
//for (double i = 0.2; i <= 10; i += 0.1 )
//{
//    z = 1 + Math.Sin(i);
//    c = c * z;
//}
//Console.WriteLine($"Выражение равно ={c}");
////39.22
//double summa = 0;
//Console.WriteLine("Введите число окончания");
//int z = Convert.ToInt32(Console.ReadLine());
//while (z > 0)
//{
//    Console.WriteLine("Введите очередное число последовательности a=");
//    double c = Convert.ToDouble(Console.ReadLine());
//    double x = c % 10;
//    if (x / z == 1)
//        summa += c;
//    else
//        Console.WriteLine("число не оканчивается на заданное");
//    Console.WriteLine("Продолжить ввод? Y/N");
//    if (Console.ReadLine() == "N")
//        break;
//}
//Console.WriteLine($"Сумма последовательности равна = {summa}");
//// с.39 №22
//Console.WriteLine("Введите Кол-во чисел");
//int N = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(" Введиет число");
//int number = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите последнюю цифру");
//int P = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//int count = 0;
//for (int i = 0; i < N; i++)
//{
//    if (number % 10 == P)
//    {
//        sum += i;
//        count++;
//    }

//}
//if (count > 3)
//{
//    Console.WriteLine($"Сумма трех чисел, оканчивающихся на {P}, равна {sum}.");
//}
//else
//{
//    Console.WriteLine($"Недостаточно чисел, оканчивающихся на {P}, чтобы найти сумму трех членов.");
//}
