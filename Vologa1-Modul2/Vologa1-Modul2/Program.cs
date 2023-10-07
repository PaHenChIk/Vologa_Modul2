using System;

public class Person // Определение класса Person
{
    public string Name { get; set; } // Определение свойства Name для хранения имени человека
    public double Age { get; set; } // Определение свойства Age для хранения возраста человека
    public string Address { get; set; } // Определение свойства Address для хранения адреса человека

    public Person() // Конструктор класса Person
    {
        Console.Write("Введите имя: "); 
        Name = Console.ReadLine(); // Чтение введенного имени из консоли и сохранение его в свойство Name

        Console.Write("Введите возраст: "); 
        if (!double.TryParse(Console.ReadLine(), out double age)) // Преобразование введенного возраста в число
        {
            Console.WriteLine("Некорректный ввод возраста. Пожалуйста, введите число."); // Вывод сообщения об ошибке, если введенное значение не является числом
            throw new ArgumentException("Некорректный ввод возраста"); // Генерация исключения с сообщением об ошибке
        }
        if (age < 0) // Проверка, что возраст не меньше нуля
        {
            Console.WriteLine("Такого возраста быть не может. Возраст не может быть меньше 0."); // Вывод сообщения об ошибке, если возраст меньше нуля
            throw new ArgumentException("Возраст не может быть меньше 0"); // Генерация исключения с сообщением об ошибке
        }
        else if (age > 122) // Проверка, что возраст не больше 122 лет
        {
            Console.WriteLine("Люди столько не живут. Возраст не может превышать 122 года."); // Вывод сообщения об ошибке, если возраст больше 122 лет
            throw new ArgumentException("Возраст не может превышать 122 года"); // Генерация исключения с сообщением об ошибке
        }
        Age = age; // Сохранение введенного возраста в свойство Age

        Console.Write("Введите адрес: "); 
        Address = Console.ReadLine(); // Чтение введенного адреса из консоли и сохранение его в свойство Address
    }

    public string GetInfo() // Метод для получения информации о человеке
    {
        return $"Имя: {Name}, Возраст: {Age}, Адрес: {Address}"; // Форматирование и возврат строки с информацией о человеке
    }
}

public class vivod_Person // Определение класса vivod_Person для вывода информации о человеке
{
    static void Main(string[] args) // Главный метод программы
    {
        vivod_Person VIvod_Person = new vivod_Person(); // Создание нового объекта класса vivod_Person
        VIvod_Person.Vivod_Person(); // Вызов метода Vivod_Person объекта VIvod_Person для вывода информации о человеке
    }

    public void Vivod_Person()  // Метод для вывода информации о человеке 
    {
      
            try // Блок try-catch для обработки исключений, которые могут быть сгенерированы при создании объектов класса Person
            {
                Person person1 = new Person(); // Создание нового объекта класса Person и запрос информации о человеке
                Console.WriteLine(person1.GetInfo()); // Вывод информации о человеке, используя метод GetInfo объекта person1
            }
            catch (ArgumentException) // Обработка исключений типа ArgumentException, которые могут быть сгенерированы при создании объекта класса Person
            {
               
            }
        
        
           
        
    }
}
