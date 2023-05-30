using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MathFunc
{
    internal class Algebra
    {
        public static double QuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant >= 0)
            {
                double sqrtDisc = Math.Sqrt(discriminant);
                double root1 = (-b + sqrtDisc) / (2 * a);
                double root2 = (-b - sqrtDisc) / (2 * a);

                Console.WriteLine("Первый корень квадратного уравнения: " + root1);
                Console.WriteLine("Второй корень квадратного уравнения: " + root2);
            }
            else
            {
                // Если дискриминант отрицательный 
                double sqrtReal = -b / (2 * a);
                double sqrtNotReal = Math.Sqrt(-discriminant) / (2 * a);

                Console.WriteLine("Первый корень квадратного уравнения: " + sqrtReal + " + " + sqrtNotReal + "i");
                Console.WriteLine("Второй корень квадратного уравнения: " + sqrtReal + " - " + sqrtNotReal + "i");
            }
            return 0;
        }


        public static double LinearEquation(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Уравнение имеет бесконечное множество решений.");
                }
                else
                {
                    Console.WriteLine("Уравнение не имеет решений.");
                }
            }
            else
            {
                double solution = -b / a;
                return solution;
            }
            return 0;
        }

        public static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }

            return sum;
        }

        public static int MaxArray(int[] array)
        {
            int maxElement = 0;
            foreach (int element in array)
            {
                if (element > maxElement)
                {
                    maxElement = element;
                }
            }
            return maxElement;
        }

        public static int AverageArray(int[] array)
        {
            int avg = MaxArray(array) / array.Length;

            return avg;
        }


    }

    internal class Geometry
    {
        public const double p = 3.14;
        public static double Triangle(double a, double h)
        {
            return 0.5 * a * h; // формула умножения 0.5 на сторону и высоту

        }

        public static double RightTriangle(double a, double b)
        {
            return 0.5 * a * b; // формула умножения 0.5 на два катета
        }

        public static double Rectangle(double a, double b)
        {
            return a * b; // умножение длины на ширину
        }

        public static double Round(double r)
        {
            return p * (r * r);
        }

        public static double Trapezoid(double a, double b, double h)
        {
            return (a + b) * (h / 2); // h - высота
        }

    }

    internal class Trigonometry
    {
        public static double Sin(double a, double c) // На вход подаются противолежащий катет и гипотенуза
        {
            return a / c;
        }

        public static double Cos(double b, double c) // На вход подаесть прилежащий катет и гипотенуза
        {
            return b / c;
        }

        public static double Tg(double a, double b) // На вход подаются два катета
        {
            return a / b;
        }

        public static double Ctg(double a, double b)
        {
            return b / a;
        }

        public static double ArcSin(double x) // С арксинусом так не получится. Можно написать решение через ряды Тейлора, но тк я их не особо понимаю (и не изучала), использую внутренний метод Math.Atan
        {
            double value = x / Math.Sqrt(1 - x * x);
            double arcSin = Math.Atan(value);

            return arcSin;
        }
    }
}
