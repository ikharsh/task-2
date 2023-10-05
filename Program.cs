using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Program
    {
        //Write a program in C# Sharp to count the number of digits in a number using recursion.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input any positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var result = CountDigits(number);
            Console.WriteLine("Number of digits in " + number + " is: " + result);
            Console.ReadLine();

        }
        public static int CountDigits(int num)
        {
            if (num < 10)
                return 1;

            return 1 + CountDigits(num / 10);
        }

        //Write a program in C# Sharp to find the factorial of a given number using recursion.
        /*static void Main(string[] args)
         {

             Console.WriteLine("Input any positive number: ");
             int number = Convert.ToInt32(Console.ReadLine());
             var result = getString(number);
             Console.WriteLine("The factorial of " +number+ " is: " + result);
             Console.ReadLine();

         }
         public static int getString(int number)
         {
             if (number == 0)
             {
                 return 1;
             }
             else
             {
                 return (number * getString(number-1));
             }
         }


        //Write a program in C to print even or odd numbers in a given range using recursion.
        static void Main(string[] args)
         {
             Console.WriteLine("Input the range to print from 1 = ");
             int n = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("\n All even numbers from 1 to " + "n" + "are : ");
             printOddEven(2, n);

             Console.WriteLine("\n All odd numbers from 1 to " + "n" + "are : ");
             printOddEven(1, n);

             Console.ReadLine();
         }

         static void printOddEven(int value, int n)
         {
             if (value > n)
             {
                 return;
             }
             else
             {
                 Console.WriteLine(value);
                 printOddEven(value + 2, n);
             }
         }


        //Write a program in C# Sharp to display a right angle triangle with an asterisk.
        static void Main(string[] args)
         {
             int x = 4;
             for(int i = 1; i <= x; i++)
             {
                 for(var j = 1; j <= (x-i); j++)
                 {
                     Console.Write(" ");
                 }
                 for(var k = 1; k <= i; k++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine(" ");
             }
             Console.ReadLine();
         }


        //Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number or terms: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int value = 9;
            int total = 0;
            for(int i = 1; i <= x; i++)
            {
                total += value;
                Console.WriteLine($"{value} ");
                value = value * 10 + 9;
                
            }
            Console.WriteLine("The sum of the series = "+ total);
            Console.ReadLine();
        }


        //Write a program in C# Sharp to find prime numbers within a range of numbers.
        static void Main(string[] args)
        {
            Console.Write("Input starting number of range: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            int y = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i <= y; i++)
            {
                int flag = 0;

                for (int j = 2; j <= i /2 ; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                        break;
                    }
                }

                if (flag == 0 && i != 1)
                    Console.Write("{0} ", i);
            }
            Console.Write("\n");
            Console.ReadLine(); 
            
        }


        //Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
        static void Main(string[] args)
        {
            Console.Write("Enter Temp: ");
            int temp = Convert.ToInt32(Console.ReadLine()); 

            if(temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp >= 0 && temp < 10)
            {
                Console.WriteLine("very cold weather");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("cold weather");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("normal weather");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine("It's hot");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("Very Hot");
            }
            else
            {
                Console.WriteLine("invelid input!!");
            }
            Console.ReadLine();
        }


        //Write a program in C# Sharp to accept a grade and declare the equivalent description :
        static void Main(string[] args)
        {
            Console.Write("Enter grade: ");
            string grade = Convert.ToString(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case "E":
                    Console.WriteLine("Excellent");
                    break;

                case "V":
                    Console.WriteLine("Very Good");
                    break;

                case "G":
                    Console.WriteLine("Great");
                    break;

                case "A":
                    Console.WriteLine("Average");
                    break;

                case "F":
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("invelid input");
                    break;
            }
            Console.ReadLine();

        }

        //Write a C# Sharp program to check whether a given number is positive or negative.
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num > 0)
            {
                Console.Write($"{num} is a positive number!");
            }
            else
            {
                Console.Write($"{num} is a negative number!");
            }
            Console.ReadLine();
        }


        //Write a C# Sharp program to find out whether a given year is a leap year or not.
        static void Main(string[] args)
        {
            Console.Write("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
            Console.ReadLine();
        }*/
    }
} 
