// Задание 2. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a "); double a = Convert.ToDouble(Console.ReadLine()); // ввод значения основанию "а" и присвоение типа "double"
            Console.Write("Enter b "); double b = Convert.ToDouble(Console.ReadLine()); // ввод значения основанию "b" и присвоение типа "double"
            Console.Write("Enter h "); double h = Convert.ToDouble(Console.ReadLine()); // ввод значения высоте "h" и присвоение типа "double"
            double P = a + b + 2 * Math.Sqrt(Math.Pow(h, 2) + Math.Pow((a - b), 2) / 4); // Вычисление периметра(P) трапеции и присвоение значению периметра типа "double"
            Console.Write(P); // Вывод на экран значения вычисленного периметра(P)
            Console.ReadKey(true); //ожидание нажатия клавиши и предотвращение отображения экрана до тех пор, пока не будет нажата клавиша.
        }
    }
}