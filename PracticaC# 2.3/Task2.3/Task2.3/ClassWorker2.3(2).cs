// using System;
//
// namespace Task2._3
// {
//     class Worker
//     {
//         private String Name = "";
//         private String Surname = "";
//         private int Rate;
//         private int Days;
//
//         public String name
//         {
//             get { return Name; }
//             set { this.Name = value; }
//         }
//
//         public String surname
//         {
//             get { return Surname; }
//             set { this.Surname = value; }
//         }
//
//         public int rate
//         {
//             get { return Rate; }
//             set { this.Rate = value; }
//         }
//
//         public int days
//         {
//             get { return Days; }
//             set { this.Days = value; }
//         }
//
//         public Worker(int rate, int days)
//         {
//             this.Rate = rate;
//             this.Days = days;
//         }
//
//         public int GetSalary()
//         {
//             return this.Rate * Days;
//         }
//     }
// }