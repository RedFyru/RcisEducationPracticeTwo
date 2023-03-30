using System;
using System.Data;

namespace GarageConsoleApp
{
    public class Program 
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("Нажмите Enter что бы завершить работу");
            Console.WriteLine("Введите число 1 что бы добавить тип машины к списку");
            Console.WriteLine("Введите число 2 что бы добавить водителя к списку");
            Console.WriteLine("Введите число 3 что бы добавить права к списку");
            Console.WriteLine("Введите число 4 что бы добавить машину к списку)");
            Console.WriteLine("Введите число 5 что бы добавить маршрут к списку");
            Console.WriteLine("Введите число 6 что бы добавить рейс к списку");
            Console.WriteLine("Введите число 7 что бы вывести списки");
            while (true)
            {
                Console.WriteLine("\nВведите значение");
                int number = int.Parse(Console.ReadLine()!);
                switch (number)
                {
                    case 1:
                        Console.Write("\nВведите вид транспорта: ");
                        DatabaseRequests.AddTypeCarQuery(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Введите имя водителя: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите фамилию водителя: ");
                        string surname = Console.ReadLine();
                        Console.Write("Введите дату рождения водителя: ");
                        DateTime date = Convert.ToDateTime(Console.ReadLine());
                        DatabaseRequests.AddDriverQuery(name, surname, date);
                        break;
                    case 3:
                        Console.Write("Введите категорию прав водителя: ");
                        DatabaseRequests.AddRightsCategoryQuery(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Введите id-типa машины: ");
                        int type = int.Parse(Console.ReadLine()!);
                        Console.Write("Введите марку машины: ");
                        string brand = Console.ReadLine();
                        Console.Write("Введите номер машины: ");
                        string numb = Console.ReadLine();
                        Console.Write("Введите число пассажиров: ");
                        int passengers = int.Parse(Console.ReadLine()!);
                        DatabaseRequests.AddCarQuery(type, brand, numb, passengers);
                        break;
                    case 5:
                        Console.WriteLine("Введите маршрут: ");
                        DatabaseRequests.AddItineraryQuery(Console.ReadLine()!);
                        break;
                    case 6:
                        Console.Write("Введите id-водителя: ");
                        int idDr = int.Parse(Console.ReadLine()!);
                        Console.Write("Введите id-машины: ");
                        int idCr = int.Parse(Console.ReadLine()!);
                        Console.Write("Введите id-маршрута: ");
                        int idIt = int.Parse(Console.ReadLine()!);
                        Console.Write("Введите число пассажиров: ");
                        int people = int.Parse(Console.ReadLine()!);
                        DatabaseRequests.AddRouteQuery(idDr, idCr, idIt, people);
                        break;
                    case 7:
                        Console.WriteLine("Введите число 1 что бы вывести список типов машин");
                        Console.WriteLine("Введите число 2 что бы вывести список водителей");
                        Console.WriteLine("Введите число 3 что бы вывести список категорий прав вождения");
                        Console.WriteLine("Введите число 4 что бы вывести список машин");
                        Console.WriteLine("Введите число 5 что бы вывести список маршрутов");
                        Console.WriteLine("Введите число 6 что бы вывести список рейсов");

                        int numeric = int.Parse(Console.ReadLine()!);
                        switch (numeric)
                        {
                            case 1:
                                DatabaseRequests.GetTypeCarQuery();
                                break;
                            case 2:
                                DatabaseRequests.GetDriverQuery();
                                break;
                            case 3:
                                DatabaseRequests.GetRightsCategoryQuery();
                                break;
                            case 4:
                                DatabaseRequests.GetCarQuery();
                                break;
                            case 5:
                                DatabaseRequests.GetItineraryQuery();
                                break;
                            case 6:
                                DatabaseRequests.GetRouteQuery();
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Программа завершена");
                        return;
                }
            }
        }
            /*// Вызовем метод для получения данных о водителях
            DatabaseRequests.GetDriverQuery();
            Console.WriteLine();
            // Добавим нового водителя в БД
            DatabaseRequests.AddDriverQuery("Денис", "Иванов", Convert.ToDateTime("1997.01.12"));
            // Вызовем метод для получения данных о водителях
            DatabaseRequests.GetDriverQuery();*/
          //  DatabaseRequests.AddCarQuery(1, "Toyota", "L-123-OG", 4);
           // DatabaseRequests.GetCarQuery();
           // DatabaseRequests.AddRouteQuery(1, 6, 2, 15);
            //DatabaseRequests.GetRouteQuery();
           // DatabaseRequests.AddItineraryQuery( "Владивосток-Москва");
           // DatabaseRequests.GetItineraryQuery();
            //DatabaseRequests.AddRightsCategoryQuery();
            //DatabaseRequests.GetRightsCategoryQuery();
            // Вызовем метод для получения данных о типах автомобилей
            /*DatabaseRequests.GetTypeCarQuery();
            Console.WriteLine();
            // Добавим новый тип автомобиля в БД
            DatabaseRequests.AddTypeCarQuery("Воздушный");
            // Вызовем метод для получения данных о типах автомобилей
            DatabaseRequests.GetTypeCarQuery();*/
            //   DatabaseRequests.GetDriverRightsCategoryQuery(1);
    }    
}



/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
