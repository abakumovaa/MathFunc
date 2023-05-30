// Вывод всех функций на экран. Приятного просмотра :)

// АЛГЕБРА

using MathFunc;



internal class Program
{
    private static void Main(string[] args)
    {
        // Корни квадратного уравнения

        Console.WriteLine(Algebra.QuadraticEquation(5, 3, -26));

        // Корни линейного уравнения

        Console.WriteLine("Решение линейного уравнения: " + Algebra.LinearEquation(5.4, 6.6));

        // Сумма ряда 

        int[] array = { 10, 23, 4839, 3882, -90, 0, 8392, 46, 22 };

        Console.WriteLine("Сумма ряда: " + Algebra.SumArray(array));

        // Максимум из ряда

        Console.WriteLine("Максимальный элемент ряда: " + Algebra.MaxArray(array));

        // Среднее значение ряда

        Console.WriteLine("Среднее значение элемента ряда: " + Algebra.AverageArray(array));

        // ГЕОМЕТРИЯ

        // Площадь треугольника

        Console.WriteLine("Площадь треугольника равна: " + Geometry.Triangle(4, 10));

        // Площадь прямоугольного треугольника

        Console.WriteLine("Площадь прямоугольного треугольника равна: " + Geometry.RightTriangle(6, 12));

        // Площадь прямоугольника

        Console.WriteLine("Площадь прямоугольника равна: " + Geometry.Rectangle(67, 56));

        // Площадь круга

        Console.WriteLine("Площадь круга равна: " + Geometry.Round(6.78));

        // Площадь трапеции

        Console.WriteLine("Площадь трапеции равна: " + Geometry.Trapezoid(5, 7, 3));

        // ТРИГОНОМЕТРИЯ

        // Синус

        // Буду делать решение через противолежащие катеты и гипотенузу, потому что я глупенькая и мне не пришло в голову, как сделать это лучше

        Console.WriteLine("Синус угла альфа прямоугольного треугольника: " + Trigonometry.Sin(5, 6));

        // Косинус

        Console.WriteLine("Косинус угла альфа прямоугольного треугольника: " + Trigonometry.Cos(7, 6));

        // Тангенс

        Console.WriteLine("Тангенс угла альфа прямоугольного треугольника: " + Trigonometry.Tg(5, 7));

        // Котангенс

        Console.WriteLine("Котангенс угла альфа прямоугольного треугольника: " + Trigonometry.Ctg(5, 7));

        // Арксинус

        Console.WriteLine("Арксинус x: " + Trigonometry.ArcSin(-1));

    }
}

