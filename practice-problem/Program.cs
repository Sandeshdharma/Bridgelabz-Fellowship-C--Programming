//using System;

//class EmployeeWage
//{
//    static void Main()
//    {
//        Console.Write("Enter wage per hour: ");
//        int wagePerHour = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter full time hrs ");
//        int fullTime = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter part time hrs ");
//        int partTime = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter number of working day: ");
//        int days = Convert.ToInt32(Console.ReadLine());

//        int totalHours = 0;

//        Random random = new Random();

//        for (int i = 1; i <= days; i++)
//        {
//            int attendance = random.Next(0, 3);
//            int dailyHours = 0;

//            if (attendance == 1)
//                dailyHours = fullTime;
//            else if (attendance == 2)
//                dailyHours = partTime;
//            else
//                dailyHours = 0;

//            totalHours += dailyHours;

//            Console.WriteLine("Day " + i + " -> Hours: " + dailyHours);
//        }

//        int totalSalary = totalHours * wagePerHour;

//        Console.WriteLine("Total Hours: " + totalHours);
//        Console.WriteLine("Total Salary: " + totalSalary);
//    }
//}