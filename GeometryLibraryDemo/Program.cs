using GeometryLibrary.Extensions;
using GeometryLibrary.Figures;

namespace GeometryLibraryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования библиотеки
            Circle circle = new Circle(5);
            Console.WriteLine($"Площадь круга с радиусом 5: {circle.GetArea()}");

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Площадь треугольника со сторонами 3, 4, 5: {triangle.GetArea()}");
            Console.WriteLine($"Треугольник со сторонами 3, 4, 5 прямоугольный? {triangle.IsRightAngled()}");

            var figures = new List<IFigure>
            {
                new Circle(5),
                new Triangle(3, 4, 5)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Площадь фигуры: {figure.GetArea()}");
            }
        }
    }
}
