using System;

public class Vologa_Modul_2 
{
    static void Main(string[] args)
    {
        vivod_Person VIvod_Person = new vivod_Person(); // Создание нового объекта класса vivod_Person
        VIvod_Person.Vivod_Person(); // Вызов метода Vivod_Person объекта VIvod_Person для вывода информации о человеке

        Vivod_Figur vivod_Figur = new Vivod_Figur(); // Создание объекта класса Vivod_Figur
        vivod_Figur.vivod_figur(); // Вызов метода vivod_figur

        Vivod_Author_Book vivod_author_book = new Vivod_Author_Book(); // Создание объекта класса Vivod_Author_Book
        vivod_author_book.Vivod_author_book(); // Вызов метода Vivod_author_book

        Interface iNterface = new Interface();// Создание объекта класса Interface
        iNterface.vivod_Interface();// Вызов метода vivod_Interface

        vivod_Temperature vivod_tEmperature = new vivod_Temperature(); // Создаем экземпляр класса vivod_Temperature
        vivod_tEmperature.vivod_temperature(); // Вызываем метод vivod_temperature()

        Vivod_Studenta vivod_studenta = new Vivod_Studenta(); // Создание экземпляра класса Vivod_Studenta.
        vivod_studenta.Vivod_studenta(); // Вызов метода Vivod_studenta().

        Trains trainProgram = new Trains(); // Создание экземпляра класса "Поезда".
        trainProgram.vivod_trains(); // Вызов метода для ввода данных о поездах и вывода информации о них.

        Figuri figuri = new Figuri(); // Создание экземпляра класса "Фигуры".
        figuri.vivod_Figuri(); // Вызов метода для ввода данных о фигурах и вывода информации о них.
    }
}
