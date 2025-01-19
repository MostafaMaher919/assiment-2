using System;
using System.Globalization;

namespace assiment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Q1

            //Console.WriteLine("Pelese Enter Number");
            //int x = int.Parse(Console.ReadLine());


            //if (x % 3 == 0 && x % 4 == 0)
            //{

            //    Console.WriteLine("yes");

            //}
            //else
            //{

            //    Console.WriteLine("no");
            //}

            //#endregion

            //#region Q2

            //Console.WriteLine("Pelese Enter Number");
            //int x = int.Parse(Console.ReadLine());


            //if (x < 0)
            //{

            //    Console.WriteLine("negative");

            //}
            //else if (x > 0)
            //{


            //    Console.WriteLine("positive");
            //}
            //else
            //{
            //    Console.WriteLine(" zero is not negative or positive");
            //}


            //#endregion



            //#region Q3

            //Console.WriteLine("Pelese Enter Number 1");
            //int num1 = int.Parse(Console.ReadLine());


            //Console.WriteLine("Pelese Enter Number 2 ");
            //int num2 = int.Parse(Console.ReadLine());


            //Console.WriteLine("Pelese Enter Number 3");
            //int num3 = int.Parse(Console.ReadLine());


            //if (num1 > num2 && num1 > num3)
            //{
            //    Console.WriteLine("Max value is :" + num1);
            //    if (num3 > num2)
            //    {
            //        Console.WriteLine("Min value is :" + num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Min value is :" + num3);
            //    }

            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine("Max value is :" + num2);
            //    if (num3 > num1)
            //    {
            //        Console.WriteLine("Min value is :" + num1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Min value is :" + num3);
            //    }

            //}
            //else if (num3 > num1 && num3 > num2)
            //{
            //    Console.WriteLine("Max value is :" + num3);
            //    if (num1 > num2)
            //    {
            //        Console.WriteLine("Min value is :" + num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Min value is :" + num1);
            //    }
            //}






            //#endregion





            //#region Q4
            //Console.WriteLine("Pelese Enter Number");
            //int x = int.Parse(Console.ReadLine());


            //if (x % 2 ==0 || x == 0)
            //{
            //    Console.WriteLine("This number is : Even");

            //}
            //else
            //{
            //    Console.WriteLine("This number is : Odd");
            //}


            //#endregion



            //#region Q5
            // Console.Write("Enter Char :");

            // string x = Console.ReadLine();


            // switch (x)
            // {
            //     case "a":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "A":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "e":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "E":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "i":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "I":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "o":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "O":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "u":
            //         Console.WriteLine("vowel");
            //         break;
            //     case "U":
            //         Console.WriteLine("vowel");
            //         break;
            //     default:
            //         Console.WriteLine("Consonant");
            //         break;


            // }


            // #endregion 




            //#region Q7
            //Console.WriteLine("Pelese Enter Number");
            //int x = int.Parse(Console.ReadLine());
            //int value = 0;

            //for (int i = 1; i <= 12; i++)
            //{   
            //    value = i * x ;
            //    Console.Write(value + " ");
            //}

            //#endregion

            //#region Q9
            //Console.WriteLine("Pelese Enter Number");
            //int x= int.Parse(Console.ReadLine());

            //Console.WriteLine("Pelese Enter Power");
            //int y = int.Parse(Console.ReadLine());
            //int value = 1;


            //for (int i = 1; i < x; i++)
            //{
            //    value = value  * x;

            //}
            //Console.WriteLine(  value);


            //#endregion


            //#region Q10

            //int total = 0;

            //Console.WriteLine("Enter marks of five subjects:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Subject {i + 1}: ");
            //    int x = int.Parse(Console.ReadLine());
            //    if (x <= 100)
            //    {
            //        total += x;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Max degree is 100 Pelese Enter vailed Degree :");
            //        i--;
            //    }
            //}


            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;


            //Console.WriteLine("\nResults:");
            //Console.WriteLine($"Total Marks: {total}");
            //Console.WriteLine($"Average Marks: {average}");
            //Console.WriteLine($"Percentage: {percentage}%");


            //#endregion




            //#region Q11


            //Console.Write("Enter Month Number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //int days;
            //int m1 = 30;
            //int m2 = 31;



            //switch (month)
            //{
            //    case 1:
            //        days = m1;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 2:
            //        days = 28;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 3:
            //        days = m1;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 4:
            //        days = m2;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 5:
            //        days = m1;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 6:
            //        days = m2;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 7:
            //        days = m2;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 8:
            //        days = m1;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 9:
            //        days = m1;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 10:
            //        days = m2;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 11:
            //        days = m1;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    case 12:
            //        days = m2;
            //        Console.WriteLine("Days in Month: " + days);
            //        break;
            //    default :
            //        Console.WriteLine("Not found Enter Month Number (1-12)");
            //        break;



            //}


            //#endregion


            //#region Q17 get help from gpt

            //Console.WriteLine("Enter the coordinates of the first point (x1, y1):");
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the second point (x2, y2):");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the coordinates of the third point (x3, y3):");
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());


            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            //#endregion

            // #region Q18
            //Console.WriteLine("Enter the time taken to complete the task (in hours):");
            // double timeTaken = double.Parse(Console.ReadLine());

            // if (timeTaken >= 2 && timeTaken <= 3)
            // {
            //     Console.WriteLine("The worker is highly efficient.");
            // }
            // else if (timeTaken > 3 && timeTaken <= 4)
            // {
            //     Console.WriteLine("The worker is instructed to increase their speed.");
            // }
            // else if (timeTaken > 4 && timeTaken <= 5)
            // {
            //     Console.WriteLine("The worker is provided with training to enhance their speed.");
            // }
            // else if (timeTaken > 5)
            // {
            //     Console.WriteLine("The worker is required to leave the company.");
            // }
            // else
            // {
            //    Console.WriteLine("Invalid time. Time taken should be 2 hours or more.");
            // }
            // #endregion




            //#region Q21
            //int num1 = 10;
            //int num2 = num1;  
            //Console.WriteLine("Before modification:");
            //Console.WriteLine("num1: " + num1); 
            //Console.WriteLine("num2: " + num2); 

            //num1 = 20;

            //Console.WriteLine("\nAfter modification:");
            //Console.WriteLine("num1: " + num1); 
            //Console.WriteLine("num2: " + num2);

            //#endregion


            //#region Q22

            //Person person1 = new Person("Alice", 25);


            //Person person2 = person1;

            //Console.WriteLine("Before modification:");
            //Console.WriteLine("person1 Name: " + person1.Name + ", Age: " + person1.Age); 
            //Console.WriteLine("person2 Name: " + person2.Name + ", Age: " + person2.Age);


            //person2.Name = "Bob";
            //person2.Age = 30;

            //Console.WriteLine("\nAfter modification:");
            //Console.WriteLine("person1 Name: " + person1.Name + ", Age: " + person1.Age); 
            //Console.WriteLine("person2 Name: " + person2.Name + ", Age: " + person2.Age); 

            //#endregion


















            //#region Q23
            //// answer is B
            //#endregion


            //#region Q24
            //// answer is D

            //#endregion


            //#region Q25
            //// answer is C

            //#endregion

















        }
    }
}
