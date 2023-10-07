using System; 

public abstract class Shape // Абстрактный класс Shape
{
    public abstract double Area(); // Абстрактный метод для вычисления площади
    public abstract double Perimeter(); // Абстрактный метод для вычисления периметра
}

public class Circle : Shape // Класс Circle, наследующий от Shape
{
    public double radius; // Приватное поле для радиуса

    public Circle() // Конструктор класса Circle
    {
        Console.Write("Введите радиус круга: "); // Запрос на ввод радиуса
        if (!double.TryParse(Console.ReadLine(), out radius)) // Преобразование введенного значения в double
        {
            Console.WriteLine("Некорректный ввод радиуса. Пожалуйста, введите число."); // Сообщение об ошибке
            throw new ArgumentException("Некорректный ввод радиуса"); // Генерация исключения
        }
    }

    public override double Area() // Переопределение метода Area для круга
    {
        return Math.PI * Math.Pow(radius, 2); // Возвращаем площадь круга
    }

    public override double Perimeter() // Переопределение метода Perimeter для круга
    {
        return 2 * Math.PI * radius; // Возвращаем периметр круга
    }
}

public class Rectangle : Shape // Класс Rectangle, наследующий от Shape
{
    public double length; // Приватное поле для длины
    public double width; // Приватное поле для ширины

    public Rectangle() // Конструктор класса Rectangle
    {
        Console.Write("Введите длину прямоугольника: "); // Запрос на ввод длины
        if (!double.TryParse(Console.ReadLine(), out length)) // Преобразовать введенного значения в double
        {
            Console.WriteLine("Некорректный ввод длины. Пожалуйста, введите число."); // Сообщение об ошибке
            throw new ArgumentException("Некорректный ввод длины"); // Генерация исключения
        }

        Console.Write("Введите ширину прямоугольника: "); // Запрос на ввод ширины
        if (!double.TryParse(Console.ReadLine(), out width)) // Попытка преобразовать введенное значение в double
        {
            Console.WriteLine("Некорректный ввод ширины. Пожалуйста, введите число."); // Сообщение об ошибке
            throw new ArgumentException("Некорректный ввод ширины"); // Генерация исключения
        }
    }

    public override double Area() // Переопределение метода Area для прямоугольника
    {
        return length * width; // Возвращаем площадь прямоугольника
    }

    public override double Perimeter() // Переопределение метода Perimeter для прямоугольника
    {
        return 2 * (length + width); // Возвращаем периметр прямоугольника
    }
}

public class Vivod_Figur // Класс Vivod_Figur для вывода информации о фигурах 
{
    static void Main(string[] args) // Главный метод программы
    {
        Vivod_Figur vivod_Figur = new Vivod_Figur(); // Создание объекта класса Vivod_Figur
        vivod_Figur.vivod_figur(); // Вызов метода vivod_figur
    }

    public void vivod_figur() // Метод vivod_figur для вывода информации о фигурах 
    {
       
        
            try // Блок try для обработки исключений
            {
                Circle circle = new Circle(); // Создание объекта класса Circle
                Console.WriteLine($"Площадь круга: {circle.Area()}, Периметр круга: {circle.Perimeter()}"); // Вывод площади и периметра круга

                Rectangle rectangle = new Rectangle(); // Создание объекта класса Rectangle
                Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}, Периметр прямоугольника: {rectangle.Perimeter()}"); // Вывод площади и периметра прямоугольника
            }
            catch (ArgumentException) // Обработка исключения ArgumentException
            {
               
            }
       
    }
}

