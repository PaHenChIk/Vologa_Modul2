using System; 

using System.Text.RegularExpressions; 

using System.Numerics;

public class Student // Определение класса "Студент".
{
    private string firstName; // Приватное поле для хранения имени студента.
    private string lastName; // Приватное поле для хранения фамилии студента.
    private BigInteger age; // Приватное поле для хранения возраста студента.
    private double averageScore; // Приватное поле для хранения среднего балла студента.

    public string FirstName // Свойство для доступа к имени студента.
    {
        get { return firstName; } // Геттер для получения имени студента.
        set // Сеттер для установки имени студента.
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Zа-яА-Я]+$")) // Проверка введенного имени на соответствие условию (только буквы).
                throw new Exception("Имя студента должно содержать только буквы."); // Генерация исключения, если имя не соответствует условию.
            firstName = value; // Установка значения имени студента.
        }
    }

    public string LastName // Свойство для доступа к фамилии студента.
    {
        get { return lastName; } // Геттер для получения фамилии студента.
        set // Сеттер для установки фамилии студента.
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Zа-яА-Я]+$")) // Проверка введенной фамилии на соответствие условию (только буквы).
                throw new Exception("Фамилия студента должна содержать только буквы."); // Генерация исключения, если фамилия не соответствует условию.
            lastName = value; // Установка значения фамилии студента.
        }
    }

    public BigInteger Age // Свойство для доступа к возрасту студента.
    {
        get { return age; } // Геттер для получения возраста студента.
        set // Сеттер для установки возраста студента.
        {
            if (value < 0 || value > 122) // Проверка введенного возраста на соответствие условию (от 0 до 122).
                throw new Exception("Возраст студента должен быть в диапазоне от 0 до 122 лет."); // Генерация исключения, если возраст не соответствует условию.
            age = value; // Установка значения возраста студента.
        }
    }

    public double AverageScore // Свойство для доступа к среднему баллу студента.
    {
        get { return averageScore; } // Геттер для получения среднего балла студента.
        set // Сеттер для установки среднего балла студента.
        {
            if (value < 0.0 || value > 10.0) // Проверка введенного среднего балла на соответствие условию (от 0.0 до 10.0).
                throw new Exception("Средний балл должен быть в диапазоне от 0.0 до 10.0."); // Генерация исключения, если средний балл не соответствует условию.
            averageScore = value; // Установка значения среднего балла студента.
        }
    }

    public Student(string firstName, string lastName, BigInteger age, double averageScore) // Конструктор класса "Студент".
    {
        FirstName = firstName; // Установка значения имени студента.
        LastName = lastName; // Установка значения фамилии студента.
        Age = age; // Установка значения возраста студента.
        AverageScore = averageScore; // Установка значения среднего балла студента.
    }

    public void PrintStudentInfo() // Метод для вывода информации о студенте.
    {
        Console.WriteLine($"Имя: {FirstName}, Фамилия: {LastName}, Возраст: {Age}, Средний балл: {AverageScore}"); // Вывод информации о студенте.
    }
}

public class Vivod_Studenta // Класс для вывода информации о студенте.
{
    static void Main(string[] args) // Главный метод программы.
    {
        Vivod_Studenta vivod_studenta = new Vivod_Studenta(); // Создание экземпляра класса Vivod_Studenta.
        vivod_studenta.Vivod_studenta(); // Вызов метода Vivod_studenta().
    }

    public void Vivod_studenta() // Метод для ввода данных о студенте и вывода информации о нем.

    {

        try // Блок try-catch для обработки исключений.
        {
            Console.Write("Введите имя студента: "); 
            string firstName = Console.ReadLine(); // Чтение ввода пользователя.

            Console.Write("Введите фамилию студента: "); 
            string lastName = Console.ReadLine(); // Чтение ввода пользователя.

            Console.Write("Введите возраст студента: "); 
            BigInteger age = BigInteger.Parse(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в BigInteger.

            Console.Write("Введите средний балл студента: "); 
            double averageScore = Convert.ToDouble(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в double.

            Student student = new Student(firstName, lastName, age, averageScore); // Создание экземпляра класса "Студент" с введенными данными.
            student.PrintStudentInfo(); // Вызов метода PrintStudentInfo() для вывода информации о студенте.
            Console.ReadKey(); // Ожидание нажатия клавиши пользователем перед завершением программы.
        }
        catch (FormatException) // Обработка исключений формата ввода.
        {
            Console.WriteLine("Произошла ошибка: Возраст студента должен быть в диапазоне от 0 до 122 лет."); // Вывод сообщения об ошибке.
        }
        catch (Exception ex) // Обработка всех остальных исключений.
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}"); // Вывод сообщения об ошибке.
        }

        Console.ReadKey(); // Ожидание нажатия клавиши пользователем перед завершением программы.
    }
}
