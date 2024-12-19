namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            //Console.WriteLine("Enter Your Number To Print All Numbers Between 1 To This Number ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= num; i++) { Console.Write($"{i}, "); }
            #endregion

            #region 2.Write a program that allows the user to insert an integer then print a multiplication table up to 12

            //Console.WriteLine("Enter Number to print a multiplication table up to 12:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 12; i++) { Console.Write($"{i*num} "); }

            #endregion

            #region 3.Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter Number to print print all even numbers between 1 to this number:");
            //int Counter = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < Counter; i++) { if(i % 2 ==0) Console.Write($"{i} "); }

            #endregion

            #region 4.Write a program that takes two integers then prints the power

            //Console.WriteLine("Enter First Number You Want to Get The power : ");
            //float inputNum = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Power Number: ");
            //float Power = float.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Pow(inputNum,Power));

            #endregion

            #region 5.Write a program to enter marks of five subjects and calculate total, average and percentage

            //Console.WriteLine("Enter Marks of five subjects:");

            //Console.Write("Subject 1: ");
            //int subject1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Subject 2: ");
            //int subject2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Subject 3: ");
            //int subject3 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Subject 4: ");
            //int subject4 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Subject 5: ");
            //int subject5 = Convert.ToInt32(Console.ReadLine());

            //int total = subject1 + subject2 + subject3 + subject4 + subject5;
            //float averageMarks = total / 5;
            //float percentage = averageMarks;

            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average Marks = {averageMarks}");
            //Console.WriteLine($"Percentage = {percentage}%");

            #endregion

            #region 6.Write a program to input the month number and print the number of days in that month
            //Console.WriteLine("Enter Month To Get The Number of Days");
            //int month = int.Parse(Console.ReadLine());
            //int days;
            
            //switch(month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        Console.Write("Enter the year to check for leap year: ");
            //        int year = int.Parse(Console.ReadLine());
            //        days = (DateTime.IsLeapYear(year)) ? 29 : 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            //        return;
            //}
            //Console.WriteLine($"Days in Month: {days}");

            #endregion

            Console.ReadKey();
        }
    }
}
