using System; 
using System.Text.RegularExpressions; 

public class Figuri // Определение класса "Фигуры".
{
    static void Main(string[] args) // Главный метод программы.
    {
        Figuri figuri = new Figuri(); // Создание экземпляра класса "Фигуры".
        figuri.vivod_Figuri(); // Вызов метода для ввода данных о фигурах и вывода информации о них.
    }

    public void vivod_Figuri() // Метод для ввода данных о фигурах и вывода информации о них.
    {
        try // Блок try-catch для обработки исключений.
        {
            Console.WriteLine("Введите радиус круга:"); // Вывод сообщения.
            double circleRadius = Convert.ToDouble(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в число.
            if (circleRadius < 0) throw new Exception("Радиус не может быть отрицательным числом."); // Проверка введенного радиуса на соответствие условию (неотрицательное число).
            Circle circle = new Circle(circleRadius); // Создание нового круга с введенным радиусом.
            Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр: {circle.Perimeter()}"); // Вывод площади и периметра круга.

            Console.WriteLine("Введите ширину и высоту прямоугольника:"); // Вывод сообщения.
            double rectangleWidth = Convert.ToDouble(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в число.
            double rectangleHeight = Convert.ToDouble(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в число.
            if (rectangleWidth < 0 || rectangleHeight < 0) throw new Exception("Ширина и высота не могут быть отрицательными числами."); // Проверка введенной ширины и высоты на соответствие условию (неотрицательные числа).
            Rectangle rectangle = new Rectangle(rectangleWidth, rectangleHeight); // Создание нового прямоугольника с введенной шириной и высотой.
            Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр: {rectangle.Perimeter()}"); // Вывод площади и периметра прямоугольника.

            Console.WriteLine("Введите основание, высоту и две стороны треугольника:"); // Вывод сообщения.
            double triangleBase = Convert.ToDouble(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в число.
            double triangleHeight = Convert.ToDouble(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в число.
            double triangleSideA = Convert.ToDouble(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в число.
            double triangleSideB = Convert.ToDouble(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в число.
            if (triangleBase < 0 || triangleHeight < 0 || triangleSideA < 0 || triangleSideB < 0) throw new Exception("Основание, высота и стороны не могут быть отрицательными числами."); // Проверка введенного основания, высоты и сторон на соответствие условию (неотрицательные числа).
            Triangle triangle = new Triangle(triangleBase, triangleHeight, triangleSideA, triangleSideB); // Создание нового треугольника с введенным основанием, высотой и сторонами.
            Console.WriteLine($"Площадь треугольника: {triangle.Area()}, Периметр: {triangle.Perimeter()}"); // Вывод площади и периметра треугольника.
            Console.ReadKey(); // Ожидание нажатия клавиши пользователем перед завершением программы.
        }
        catch (FormatException) // Обработка исключений формата ввода.
        {
            Console.WriteLine("Ошибка: ввод должен быть числом."); // Вывод сообщения об ошибке.
            Console.ReadKey(); // Ожидание нажатия клавиши пользователем перед завершением программы.
        }
        catch (Exception ex) // Обработка всех остальных исключений.
        {
            Console.WriteLine($"Ошибка: {ex.Message}"); // Вывод сообщения об ошибке.
            Console.ReadKey(); // Ожидание нажатия клавиши пользователем перед завершением программы.
        }
    }
}

public abstract class Shape // Определение абстрактного класса "Фигура".
{
    public abstract double Area(); // Абстрактный метод для вычисления площади фигуры.
    public abstract double Perimeter(); // Абстрактный метод для вычисления периметра фигуры.
}

public class Circle : Shape // Определение класса "Круг", наследующего от класса "Фигура".
{
    public double Radius { get; set; } // Свойство для доступа к радиусу круга.

    public Circle(double radius) // Конструктор класса "Круг".
    {
        Radius = radius; // Установка значения радиуса круга.
    }

    public override double Area() // Метод для вычисления площади круга.
    {
        return Math.PI * Math.Pow(Radius, 2); // Возврат значения площади круга.
    }

    public override double Perimeter() // Метод для вычисления периметра круга.
    {
        return 2 * Math.PI * Radius; // Возврат значения периметра круга.
    }
}

public class Rectangle : Shape // Определение класса "Прямоугольник", наследующего от класса "Фигура".
{
    public double Width { get; set; } // Свойство для доступа к ширине прямоугольника.
    public double Height { get; set; } // Свойство для доступа к высоте прямоугольника.

    public Rectangle(double width, double height) // Конструктор класса "Прямоугольник".
    {
        Width = width; // Установка значения ширины прямоугольника.
        Height = height; // Установка значения высоты прямоугольника.
    }

    public override double Area() // Метод для вычисления площади прямоугольника.
    {
        return Width * Height; // Возврат значения площади прямоугольника.
    }

    public override double Perimeter() // Метод для вычисления периметра прямоугольника.
    {
        return 2 * (Width + Height); // Возврат значения периметра прямоугольника.
    }
}

public class Triangle : Shape // Определение класса "Треугольник", наследующего от класса "Фигура".
{
    public double Base { get; set; } // Свойство для доступа к основанию треугольника.
    public double Height { get; set; } // Свойство для доступа к высоте треугольника.
    public double SideA { get; set; } // Свойство для доступа к первой стороне треугольника.

    public double SideB { get; set; } // Свойство для доступа ко второй стороне треугольника.

    public Triangle(double baseLength, double height, double sideA, double sideB) // Конструктор класса "Треугольник".
    {
        Base = baseLength; // Установка значения основания треугольника.
        Height = height; // Установка значения высоты треугольника.
        SideA = sideA; // Установка значения первой стороны треугольника.
        SideB = sideB; // Установка значения второй стороны треугольника.
    }

    public override double Area() // Метод для вычисления площади треугольника.
    {
        return 0.5 * Base * Height; // Возврат значения площади треугольника.
    }

    public override double Perimeter() // Метод для вычисления периметра треугольника.
    {
        return Base + SideA + SideB; // Возврат значения периметра треугольника.
    }

}
