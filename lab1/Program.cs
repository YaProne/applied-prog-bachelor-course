using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs1
{
    class Program
    {
        static void Main(string[] args)
        {
            line first = new line();
            line second = new line();
            Console.WriteLine("Введите координату k и b для первой прямой");
            first.collection();
            Console.WriteLine("Введите координату k и b для второй прямой");
            second.collection();
            if (first.a.k != second.a.k)
            {
                double x, y;
                x = (second.a.b - first.a.b) / (first.a.k - second.a.k);
                y = second.a.k * x + second.a.b;
                Console.WriteLine("Координата X точки пересечения равна: " + x);
                Console.WriteLine("Координата Y точки пересечения равна: " + y);
            }
            else
                Console.WriteLine("Введенные прямые параллелны");
            Console.ReadKey();
        }
    }
}
