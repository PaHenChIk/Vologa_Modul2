using System; // Используем пространство имен System
using System.Text.RegularExpressions; // Используем пространство имен System.Text.RegularExpressions для работы с регулярными выражениями

public class Author // Класс Author
{
    public string Name { get; set; } // Свойство Name
    public int BirthYear { get; set; } // Свойство BirthYear

    public Author() // Конструктор класса Author
    {
        Console.Write("Введите имя автора: "); // Запрос на ввод имени автора
        Name = Console.ReadLine(); // Чтение введенного имени автора
        if (!Regex.IsMatch(Name, @"^[a-zA-Zа-яА-Я\s]+$")) // Проверка имени автора на соответствие регулярному выражению
        {
            Console.WriteLine("Некорректный ввод имени. Имя может содержать только буквы и пробелы."); // Сообщение об ошибке
            throw new ArgumentException("Некорректный ввод имени"); // Генерация исключения
        }

        Console.Write("Введите год рождения автора: "); // Запрос на ввод года рождения автора
        if (!int.TryParse(Console.ReadLine(), out int birthYear) || birthYear < 1 || birthYear > 2023) // Проверка года рождения на соответствие условиям
        {
            Console.WriteLine("Некорректный ввод года рождения. Пожалуйста, введите число от 1 до 2023."); // Сообщение об ошибке
            throw new ArgumentException("Некорректный ввод года рождения"); // Генерация исключения
        }
        BirthYear = birthYear; // Присваивание значения свойству BirthYear
    }

    public override string ToString() // Переопределение метода ToString для класса Author
    {
        return $"Имя: {Name}, Год рождения: {BirthYear}"; // Возвращаем строковое представление объекта класса Author
    }
}

public class Book // Класс Book
{
    public string Title { get; set; } // Свойство Title
    public int ReleaseYear { get; set; } // Свойство ReleaseYear
    public Author Author { get; set; } // Свойство Author

    public Book() // Конструктор класса Book
    {
        Console.Write("Введите название книги: "); // Запрос на ввод названия книги
        Title = Console.ReadLine(); // Чтение введенного названия книги
        if (!Regex.IsMatch(Title, @"^[a-zA-Z0-9а-яА-Я\s]+$")) // Проверка названия книги на соответствие регулярному выражению
        {
            Console.WriteLine("Некорректный ввод названия книги. Название может содержать только буквы, цифры и пробелы."); // Сообщение об ошибке
            throw new ArgumentException("Некорректный ввод названия книги"); // Генерация исключения
        }

        Console.Write("Введите год выпуска книги: "); // Запрос на ввод года выпуска книги
        if (!int.TryParse(Console.ReadLine(), out int releaseYear) || releaseYear < 1 || releaseYear > 2023) // Проверка года выпуска на соответствие условиям
        {
            Console.WriteLine("Некорректный ввод года выпуска. Пожалуйста, введите число от 1 до 2023."); // Сообщение об ошибке
            throw new ArgumentException("Некорректный ввод года выпуска"); // Генерация исключения
        }
        ReleaseYear = releaseYear; // Присваивание значения свойству ReleaseYear

        Console.WriteLine("Введите информацию об авторе:");
        Author = new Author(); // Создание объекта класса Author и присваивание его свойству Author
    }

    public override string ToString() // Переопределение метода ToString для класса Book
    {
        return $"Название: {Title}, Год выпуска: {ReleaseYear}, Автор: {Author}"; // Возвращаем строковое представление объекта класса Book
    }
}

public class Vivod_Author_Book // Класс Vivod_Author_Book
{
    static void Main(string[] args) // Главный метод программы
    {
        Vivod_Author_Book vivod_author_book = new Vivod_Author_Book(); // Создание объекта класса Vivod_Author_Book
        vivod_author_book.Vivod_author_book(); // Вызов метода Vivod_author_book
    }

    public void Vivod_author_book() // Метод Vivod_author_book
    {
        
            try // Блок try для обработки исключений
            {
                Book book = new Book(); // Создание объекта класса Book
                Console.WriteLine(book); // Вывод информации о книге
            }
            catch (ArgumentException) // Обработка исключения ArgumentException
            {
               
            }
        
    }
}
