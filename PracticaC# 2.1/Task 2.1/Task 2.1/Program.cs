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
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//Задание 2.1(2)(НЕДОДЕЛАНО)
//namespace Task_2._1
//{
//    class Program
//    {
//        static void Main()
//        {
//            int[] candidates = new int[7] { 10, 1, 2, 7, 6, 1, 5 };
//            int target = 8;
//            int sum = 0;
//            List<int> numbers = new List<int>();
//            List<int> check = new List<int>();
//            List<List<int>> res = new List<List<int>>();
//            Console.WriteLine(String.Join(", ", candidates));
//            for (int i = 0; i < candidates.Length; i++)
//            {
//                if (candidates[i] <= target)
//                {
//                    numbers.Add(candidates[i]);
//                }
//            }
//            numbers.Sort();
//            for (int i = 0; i < numbers.Count; i++)
//            {
//                if (target == 0)
//                {
//                    res.Add(new List<int>());
//                    break;
//                }
//                sum = 0;
//                check.Clear();
//                sum = sum + numbers[i];
//                check.Add(numbers[i]);
//                for (int j = 0; j < numbers.Count; j++)
//                {
//                    if (sum == target)
//                    {
//                        res.Add(check);
//                        break;
//                    }
//                    if (i == j)
//                    {
//                        continue;
//                    }

//                    if (sum + numbers[j] > target)
//                    {
//                        continue;
//                    }
//                    check.Add(numbers[j]);
//                    sum += numbers[j];

//                }
//            }
//            for (int i = 0; i < check.Count; i++)
//            {
//                for (int j = 0; j < check.Count - i - 1; j++)
//                {
//                    if (check[j] > check[j + 1])
//                    {
//                        int temp = check[j];
//                        check[j] = check[j + 1];
//                        check[j + 1] = temp;
//                    }
//                }
//            }

//            bool examination = true;
//            for (int i = 0; i < res.Count; i++)
//            {
//                for (int j = i + 1; j < res.Count; j++)
//                {
//                    if (res[i] == res[j])
//                    {
//                        for (int k = j; k < res.Count - 1; k++)
//                        {
//                            res[k] = res[k + 1];
//                        }
//                        res--;
//                    }
//                    else
//                    {
//                        examination = false;
//                    }
//                    if (examination == true)
//                    {
//                        res.RemoveAt(i);
//                    }
//                    else
//                    {
//                        check.Add(check[i]);
//                    }
//                }
//            }

//            for (int i = 0; i < res.Count; i++)
//            {
//                Console.WriteLine(String.Join(", ", res[i]));

//            }
//            Console.WriteLine(String.Join(", ", String.Join(", ", res)));
//        }
//        check.Clear();

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