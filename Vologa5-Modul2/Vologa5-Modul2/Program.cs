using System; 

public class TemperatureSensor // Класс датчика температуры
{
    private double _temperature; // Закрытая переменная для хранения значения температуры
    public delegate void TemperatureChangedHandler(double newTemperature); // Делегат, который будет использоваться для события изменения температуры
    public event TemperatureChangedHandler TemperatureChanged; // Событие, которое происходит при изменении температуры

    public double Temperature // Свойство для доступа к переменной _temperature
    {
        get { return _temperature; } // Возвращает значение _temperature
        set // Устанавливает значение _temperature
        {
            _temperature = value; // Присваивает новое значение _temperature
            TemperatureChanged?.Invoke(_temperature); // Вызывает событие TemperatureChanged, если оно не равно null
        }
    }
}

public class Thermostat // Класс термостата
{
    private bool _heatingOn; // Закрытая переменная для хранения состояния отопления

    public void OnTemperatureChanged(double newTemperature) // Метод, который вызывается при изменении температуры
    {
        if (newTemperature < 17) // Если температура меньше 17 градусов
        {
            Console.WriteLine("Температура снизилась. Включаем отопление."); // Выводим сообщение о включении отопления
            _heatingOn = true; 
        }
        else if (newTemperature >= 17.0) // Если температура больше или равна 17 градусам
        {
            Console.WriteLine("Температура повысилась. Выключаем отопление."); // Выводим сообщение о выключении отопления
            _heatingOn = false; 
        }
    }
}

public class vivod_Temperature // Класс для вывода температуры
{
    static void Main(string[] args) // Главный метод программы
    {
        vivod_Temperature vivod_tEmperature = new vivod_Temperature(); // Создаем экземпляр класса vivod_Temperature
        vivod_tEmperature.vivod_temperature(); // Вызываем метод vivod_temperature()
    }

    public void vivod_temperature()  // Метод для вывода температуры
    {
        var sensor = new TemperatureSensor(); // Создаем экземпляр класса TemperatureSensor
        var thermostat = new Thermostat(); // Создаем экземпляр класса Thermostat

        sensor.TemperatureChanged += thermostat.OnTemperatureChanged; // Подписываемся на событие изменения температуры

        
            Console.WriteLine("Введите новую температуру:"); 
            string input = Console.ReadLine(); // Считываем ввод пользователя
            double temperature;

            if (Double.TryParse(input, out temperature)) // Пытаемся преобразовать ввод пользователя в число типа double
            {
                sensor.Temperature = temperature; // Если преобразование успешно, устанавливаем новое значение температуры
                Console.ReadLine();
               
            }
            else
            {
                Console.WriteLine("Неправильный ввод. Пожалуйста, введите число."); // Если преобразование не удалось, выводим сообщение об ошибке
                Console.ReadLine();
                
            }
        
    }
}
