// using System;

//Задание 2.3(1)

// namespace Task2._3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         { 
//             Console.WriteLine("Нажмите Enter что бы завершить работу");
//             Console.WriteLine("Введите число 1 что бы ввести имя сотрудника");
//             Console.WriteLine("Введите число 2 что бы ввести фамилию сотрудника");
//             Console.WriteLine("Введите число 3 что бы ввести размер ставки(в день)");
//             Console.WriteLine("Введите число 4 что бы ввести количество отработанных дней");
//             Console.WriteLine("Введите число 5 что бы напечатать сотрудника");
//             Worker worker = new Worker(0, 0);
//             while (true)
//             {
//                 Console.WriteLine("\nВведите значение");
//                 String number = Console.ReadLine();
//                 switch (number)
//                 {
//                     case "1":
//                         Console.Write("Введите имя: ");
//                         worker.Name = Console.ReadLine();
//                         break;
//                     case "2":
//                         Console.Write("Введите фамилию: ");
//                         worker.Surname = Console.ReadLine();
//                         break;
//                     case "3":
//                         Console.Write("Введите размер ставки: ");
//                         worker.Rate = int.Parse(Console.ReadLine()!);
//                         break;
//                     case "4":
//                         Console.Write("Введите размер количество отработанных дней: ");
//                         worker.Days = int.Parse(Console.ReadLine()!);
//                         break;
//                     case "5":
//                         Console.Write($"\nИмя: - {worker.Name}");
//                         Console.Write($"\nФамилия: - {worker.Surname}");
//                         Console.Write($"\nСтавка: - {worker.Rate}");
//                         Console.Write($"\nОтработанные дни: - {worker.Days}");
//                         Console.Write($"\nЗарплата: - {worker.GetSalary()}\n");
//                         break;
//                     default:
//                         Console.WriteLine("Программа завершена");
//                         return;
//                 }
//             }
//         }
//     }
// }

//Задание 2.3(2)
// using System;
//
//  namespace Task2._3
//  {
//     class RKIS
//     {
//         static void Main()
//         {
//             Console.WriteLine("Нажмите Enter что бы завершить работу");
//             Console.WriteLine("Введите число 1 что бы ввести имя сотрудника");
//             Console.WriteLine("Введите число 2 что бы ввести фамилию сотрудника");
//             Console.WriteLine("Введите число 3 что бы ввести размер ставки(в день)");
//             Console.WriteLine("Введите число 4 что бы ввести количество отработанных дней");
//             Console.WriteLine("Введите число 5 что бы напечатать сотрудника");
//             Worker worker = new Worker(0, 0);
//             while (true)
//             {
//                 Console.WriteLine("\nВведите значение");
//                 String number = Console.ReadLine();
//                 switch (number)
//                 {
//                     case "1":
//                         Console.Write("Введите имя: ");
//                         worker.name = Console.ReadLine();
//                         break;
//                     case "2":
//                         Console.Write("Введите фамилию: ");
//                         worker.surname = Console.ReadLine();
//                         break;
//                     case "3":
//                         Console.Write("Введите размер ставки: ");
//                         worker.rate = int.Parse(Console.ReadLine()!);
//                         break;
//                     case "4":
//                         Console.Write("Введите размер количество отработанных дней: ");
//                         worker.days = int.Parse(Console.ReadLine()!);
//                         break;
//                     case "5":
//                         Console.Write($"\nИмя: - {worker.name}");
//                         Console.Write($"\nФамилия: - {worker.surname}");
//                         Console.Write($"\nСтавка: - {worker.rate}");
//                         Console.Write($"\nОтработанные дни: - {worker.days}");
//                         Console.Write($"\nЗарплата: - {worker.GetSalary()}\n");
//                         break;
//                     default:
//                         Console.WriteLine("Программа завершена");
//                         return;
//                 }
//             }
//         }
//     }
// }

//Задание 2.3(3)
// using System;
//
// namespace Task2._3
// {
//
//     class RKIS
//     {
//         static void Main()
//         {
//             Console.WriteLine("Нажмите Enter что бы завершить работу");
//             Console.WriteLine("Введите число 1 что бы изменить значение");
//             Console.WriteLine("Введите число 2 что бы добавить символ в конце строки");
//             Console.WriteLine("Введите число 3 что бы вывести значение");
//             Console.WriteLine("Введите число 4 что бы вывести последний символ");
//             Console.WriteLine("Введите число 5 что бы удалить последний символ");
//             Calculation calculation = new Calculation();
//             while (true)
//             {
//                 Console.WriteLine("\nВведите операцию");
//                 String number = Console.ReadLine();
//                 switch (number)
//                 {
//                     case "1":
//                         Console.Write("Введите значение: ");
//                         calculation.SetCalculationLine = Console.ReadLine();
//                         break;
//                     case "2":
//                         Console.Write("Введите символ: ");
//                         string letter = Console.ReadLine();
//                         calculation.SetLastSymbolCalculationLine(letter);
//                         break;
//                     case "3":
//                         Console.WriteLine($"Значение - {calculation.GetCalculationLine}");
//                         break;
//                     case "4":
//                         Console.WriteLine($"Последний символ - {calculation.GetLastSymbol()}");
//                         break;
//                     case "5":
//                         calculation.DeleteLastSymbol();
//                         break;
//                     default:
//                         Console.WriteLine("Программа завершена");
//                         return;
//                 }
//             }
//         }
//     }
// }