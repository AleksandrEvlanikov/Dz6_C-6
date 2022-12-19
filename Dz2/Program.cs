 
 //Задача 2: Напишите программу, которая найдёт точку пересечения
// двух прямых на плоскости, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 Double b1, k2, b2, k1, x, y;
 
 Console.Write("Введите координаты b1: ");
b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты k1: ");
 k1 = Convert.ToDouble(Console.ReadLine());

 Console.Write("Введите координаты b2: ");
 b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты k2: ");
k2 = Convert.ToDouble(Console.ReadLine());


x = (b2 - b1) / (k1 - k2);
y = (k1 * (b2 - b1)) / (k1 - k2) + b1;


{
    Console.WriteLine(x);
    Console.WriteLine(y);
}














