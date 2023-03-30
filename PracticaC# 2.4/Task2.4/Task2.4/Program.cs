using System;
using System.Collections.Generic;

//Задание 2.4

namespace Task2._4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Нажмите Enter что бы завершить работу");
            Console.WriteLine("Введите число 1 что бы записать число");
            while (true)
            {
                Console.Write("\nВведите операцию:");
                string symbol = Console.ReadLine();
                switch (symbol)
                {
                    case "1":
                        Console.Write("\nВведите число:");
                        string Roman = Console.ReadLine();
                        List<int> Nums = new List<int>();
                        int counter = 0;
                        for (int i = 0; i < Roman.Length; i++)
                        {
                            switch (Roman[i])
                            {
                                case 'I':
                                    Nums.Add(1);
                                    break;
                                case 'V':
                                    Nums.Add(5);
                                    break;
                                case 'X':
                                    Nums.Add(10);
                                    break;
                                case 'L':
                                    Nums.Add(50);
                                    break;
                                case 'C':
                                    Nums.Add(100);
                                    break;
                                case 'D':
                                    Nums.Add(500);
                                    break;
                                case 'M':
                                    Nums.Add(1000);
                                    break;
                            }
                        }
                        for (int i = 0; i < Roman.Length - 1; i++)
                        {
                            if (Nums[i] < Nums[i + 1])
                            {
                                Nums[i] = Nums[i] * (-1);
                            }
                        }

                        for (int i = 0; i < Roman.Length; i++)
                        {
                            counter = counter + Nums[i];
                        }
                        Console.WriteLine(counter);
                        break;
                    default:
                        Console.WriteLine("\nПрограмма завершена");
                        return;
                }
            }
        }
    }
}


    

        