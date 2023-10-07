using System;

using System.Linq;

public struct Train // Определение структуры "Поезд".
{
    public string Destination; // Публичное поле для хранения пункта назначения поезда.
    public int Number; // Публичное поле для хранения номера поезда.
    public DateTime DepartureTime; // Публичное поле для хранения времени отправления поезда.

    public Train(string destination, int number, DateTime departureTime) // Конструктор структуры "Поезд".
    {
        Destination = destination; // Установка значения пункта назначения поезда.
        Number = number; // Установка значения номера поезда.
        DepartureTime = departureTime; // Установка значения времени отправления поезда.
    }

    public void PrintTrainInfo() // Метод для вывода информации о поезде.
    {
        Console.WriteLine($"Пункт назначения: {Destination}, Номер поезда: {Number}, Время отправления: {DepartureTime}"); // Вывод информации о поезде.
    }
}

public class Trains // Определение класса "Поезда".
{
    Train[] trains = new Train[5]; // Массив из пяти элементов структуры "Поезд".

    public void vivod_trains() // Метод для ввода данных о поездах и вывода информации о них.
    {
        trains = trains.OrderBy(t => t.Number).ToArray(); // Сортировка массива поездов по номеру поезда.

        for (int i = 0; i < 5; i++) // Цикл для ввода данных о пяти поездах.
        {
            try // Блок try-catch для обработки исключений.
            {
                Console.WriteLine("Введите пункт назначения, номер поезда и время отправления (через пробел):"); // Вывод сообщения.
                string[] input = Console.ReadLine().Split(' '); // Чтение ввода пользователя и разделение его на части.
                trains[i] = new Train(input[0], int.Parse(input[1]), DateTime.Parse(input[2])); // Создание нового поезда с введенными данными и добавление его в массив.
            }
            catch (Exception) // Обработка всех возможных исключений.
            {
                Console.WriteLine("Неправильный ввод. Пожалуйста, попробуйте еще раз."); // Вывод сообщения об ошибке.
                i--; // Уменьшение счетчика цикла на один, чтобы повторить ввод данных для текущего поезда.
            }
        }

        try // Блок try-catch для обработки исключений.
        {
            Console.WriteLine("Введите номер поезда:"); // Вывод сообщения.
            int number = int.Parse(Console.ReadLine()); // Чтение ввода пользователя и преобразование его в число.
            Train train = trains.FirstOrDefault(t => t.Number == number); // Поиск поезда с введенным номером в массиве.
            if (train.Number != 0) // Если такой поезд найден...
                train.PrintTrainInfo(); // ...вывод информации о нем...
            else
                Console.WriteLine("Поезд с таким номером не найден."); // ...иначе вывод сообщения об ошибке.
        }
        catch (Exception) // Обработка всех возможных исключений.
        {
            Console.WriteLine("Неправильный ввод. Пожалуйста, введите номер поезда."); // Вывод сообщения об ошибке.
        }

        trains = trains.OrderBy(t => t.Destination).ThenBy(t => t.DepartureTime).ToArray(); // Сортировка массива поездов по пункту назначения и времени отправления.
    }

    static void Main(string[] args) // Главный метод программы.
    {
        Trains trainProgram = new Trains(); // Создание экземпляра класса "Поезда".
        trainProgram.vivod_trains(); // Вызов метода для ввода данных о поездах и вывода информации о них.
        Console.ReadKey(); // Ожидание нажатия клавиши пользователем перед завершением программы.
    }
}
