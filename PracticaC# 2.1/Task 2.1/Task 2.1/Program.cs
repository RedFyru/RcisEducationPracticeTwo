// using System;
// using System.Linq;

// Задание 2.1(1)
// namespace Task_2._1
// {
//     class Program
//     { 
//         static void Main()
//         { 
//             Console.Write("Введите строку 'Драгоценности': ");
//             string J = Console.ReadLine();
//             Console.Write("Введите строку 'Камни': ");
//             string S = Console.ReadLine();
//             int Symbols = S.Where(a => J.Contains(a)).Count();
//             Console.WriteLine(Symbols);
//         }
//     }
// }

//using System;
//using System.Collections.Generic;
////Задание 2.1(2)

//namespace RKIS
//{
//    class Program
//    {
//        static string sort(string number1)
//        {
//            char[] number = number1.ToCharArray();
//            for (int i = 0; i < number.Length - 1; i++)
//            {
//                for (int j = 0; j < number.Length - i - 1; j++)
//                {
//                    if (int.Parse(number[j].ToString()) > int.Parse(number[j + 1].ToString()))
//                    {
//                        // меняем элементы местами
//                        char temp = number[j];
//                        number[j] = number[j + 1];
//                        number[j + 1] = temp;
//                    }
//                }
//            }
//            return new string(number);
//        }

//        static void Main()
//        {
//            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 };
//            int target = 8;
//            Console.WriteLine($"Цель- {target}");
//            Console.WriteLine("Первоначальный массив: ");
//            Console.WriteLine(String.Join(", ", candidates));
//            List<string> result = new List<string>();
//            Console.WriteLine("Список всех вариантов: ");
//            for (int i = 0; i < Math.Pow(2, candidates.Length); i++)
//            {
//                int sum = 0;
//                string res = "";
//                double b = i;
//                int r = 0;
//                while (r < candidates.Length)
//                {
//                    double c = b;
//                    b = Math.Floor(b / 2);
//                    if (b * 2 != c)
//                    {
//                        sum += candidates[r];
//                        res += candidates[r];
//                    }
//                    r++;
//                }
//                if (sum == target)
//                {
//                    result.Add(res);
//                }
//            }
//            HashSet<string> resultSet = new HashSet<string>();
//            for (int i = 0; i < result.Count; i++)
//            {
//                resultSet.Add(sort(result[i]));
//            }
//            Console.WriteLine(String.Join(", ", resultSet));
//        }
//    }
//}


// using System;
// //Задание 2.1(3)
// namespace Task_2._1
// {
//     class Program
//     {
//         static void Main()
//         {
//             int[] nums = new int[7];
//             Random rand = new Random();
//             bool check = false;
//             for(int i = 0; i < nums.Length; i++)
//             {
//                 nums[i] = rand.Next(100);
//                 Console.Write($"{nums[i]} ");
//             }
//             Array.Sort(nums);
//             for (int i = 0; i < nums.Length - 1; i++)
//             {
//                 if (nums[i] == nums[i + 1])
//                 {
//                     check = true;
//                     break;
//                 }
//                 else
//                 {
//                    check = false;
//                 }
//             }
//             Console.WriteLine($"\n{check}");
//         }
//     }
// }