using System; 

public interface IDrawable // Интерфейс IDrawable, который определяет метод Draw
{
    void Draw(); // Метод Draw, который должен быть реализован в классах, реализующих этот интерфейс
}

public class Circle : IDrawable // Класс Circle, реализующий интерфейс IDrawable
{
    public double Radius { get; set; } // Свойство Radius для хранения радиуса круга

    public Circle(double radius) // Конструктор класса Circle, принимающий радиус круга в качестве параметра
    {
        Radius = radius; // Присваивание значения параметра свойству Radius
    }

    public void Draw() // Реализация метода Draw для класса Circle
    {
        Console.WriteLine($"Рисуем круг с радиусом {Radius}"); // Вывод информации о круге
    }
}

public class Rectangle : IDrawable // Класс Rectangle, реализующий интерфейс IDrawable
{
    public double Width { get; set; } // Свойство Width для хранения ширины прямоугольника
    public double Height { get; set; } // Свойство Height для хранения высоты прямоугольника

    public Rectangle(double width, double height) // Конструктор класса Rectangle, принимающий ширину и высоту прямоугольника в качестве параметров
    {
        Width = width; // Присваивание значения параметра свойству Width
        Height = height; // Присваивание значения параметра свойству Height
    }

    public void Draw() // Реализация метода Draw для класса Rectangle
    {
        Console.WriteLine($"Рисуем прямоугольник шириной {Width} и высотой {Height}"); // Вывод информации о прямоугольнике
    }
}

public class Triangle : IDrawable // Класс Triangle, реализующий интерфейс IDrawable
{
    public double Base { get; set; } // Свойство Base для хранения основания треугольника
    public double Height { get; set; } // Свойство Height для хранения высоты треугольника

    public Triangle(double baseLength, double height) // Конструктор класса Triangle, принимающий основание и высоту треугольника в качестве параметров
    {
        Base = baseLength; // Присваивание значения параметра свойству Base
        Height = height; // Присваивание значения параметра свойству Height
    }

    public void Draw() // Реализация метода Draw для класса Triangle
    {
        Console.WriteLine($"Рисуем треугольник с основанием {Base} и высотой {Height}"); // Вывод информации о треугольнике
    }
}

public class Interface // Класс Interface
{
    static void Main(string[] args) // Главный метод программы
    {
        Interface iNterface = new Interface();
        iNterface.vivod_Interface();
    }

    public void vivod_Interface()
    {
        Console.WriteLine("Введите радиус круга:");
        double circleRadius = ReadDouble();

        Console.WriteLine("Введите ширину прямоугольника:");
        double rectangleWidth = ReadDouble();

        Console.WriteLine("Введите высоту прямоугольника:");
        double rectangleHeight = ReadDouble();

        Console.WriteLine("Введите основание треугольника:");
        double triangleBase = ReadDouble();

        Console.WriteLine("Введите высоту треугольника:");
        double triangleHeight = ReadDouble();

        IDrawable[] drawables = new IDrawable[]
        {
            new Circle(circleRadius),  // Создаем объект класса Circle с заданным радиусом и добавляем его в массив drawables
            new Rectangle(rectangleWidth, rectangleHeight),  // Создаем объект класса Rectangle с заданными шириной и высотой и добавляем его в массив drawables
            new Triangle(triangleBase, triangleHeight)  // Создаем объект класса Triangle с заданным основанием и высотой и добавляем его в массив drawables
        };

        foreach (var drawable in drawables)  // Проходим по каждому элементу массива drawables
        {
            drawable.Draw();  // Вызываем метод Draw для текущего элемента
        }

        Console.ReadKey();  // Ждем нажатия клавиши пользователем, чтобы консольное окно не закрылось сразу после выполнения программы
    }

    private double ReadDouble()  // Метод для безопасного чтения числа типа double из консоли
    {
        while (true)  // Бесконечный цикл, который будет продолжаться, пока пользователь не введет корректное число
        {
            string input = Console.ReadLine();  // Читаем строку из консоли
            if (double.TryParse(input, out double result))  // Пытаемся преобразовать строку в число типа double
            {
                return result;  // Если преобразование успешно, возвращаем полученное число
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");  // Если преобразование не удалось, выводим сообщение об ошибке и повторяем цикл
            }
        }
    }
}
