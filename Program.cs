

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)

        {   
            //User Input Basic in C Sharp
            /*
            {

                Console.WriteLine("Enter your name:");
                string userName = Console.ReadLine();
                Console.WriteLine("Hello, " + userName + "!");

                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You are " + age + " years old.");
            }*/

            /*Console.WriteLine("Enter A Letter: ");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter >= 'A' && letter <= 'Z') 
            {
                Console.WriteLine($"{letter} is capital");
                
              }
            else
            {
                Console.WriteLine($"{letter} is Small");
            }*/




            /*
                        //Switch statement Basic structure:( switch, case, break,default)

                        int digite;
                        Console.WriteLine("Enter Single Digit: ");
                        digite = Convert.ToInt32(Console.ReadLine());

                        switch (digite)
                        {
                            case 0:
                                Console.WriteLine("Zero");
                                break;
                            case 1:
                                Console.WriteLine("One");
                                break;
                            case 2:
                                Console.WriteLine("Two");
                                break;  
                            case 3:
                                Console.WriteLine("Three");
                                break;
                            default:
                                 Console.WriteLine("Abd deo");
                                break;  
                                      */



            /*  string day;
              Console.WriteLine("Enter A day: ");
              day = Console.ReadLine();

              switch(day.ToLower()) {       //ইনপুট বড় বা ছোট যেই লেটারেই নেই না কেন, এই ব্যাটা ToLower(), সব গুলারে ছোট হাতের বানায়ে দিবে।
                                            //লখ্যনিয় যে, এর ভেতর সব ছোট হাতের দিতে হবে, নাইলে কি্নতু হবে না।
                  case "sunday":
                  case "monday":
                  case "tuesday":
                  case "wednesday":
                  case "thursday":
                      Console.WriteLine("Not Holliday");
                      break;

                  case "friday":
                  case "Saturday":
                      Console.WriteLine("Hollyday");
                      break;

                  default:
                      Console.WriteLine("Abr input koro, thik hoiai");
                      break;
            */



            /*
            //জোড বিজোড় সংখ্যা নির্নয় Switch case দারা

            Console.WriteLine("enter Number between 1 to 10");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case int x when x % 2 == 0:   //এইখানে একটা ভুল হইসিল যে, ভুলে এসাইন্মেন্ট অপারেটর (=) একটা সমান ব্যবহার করেছিলাম, কিন্তু এখানে সঠিক হচ্ছে Equality Operator (==) ব্যবহার করা
                    Console.WriteLine($"Even Number");
                    break;

                case int x when x % 2 != 0:
                    Console.WriteLine($"Odd number");
                    break;
                default:
                    Console.WriteLine("Number in not in this range");
                    break;

            }
            */



            //Basic Calculator (Using User input and switch case)

            /*
            int number1, number2;
            char operation;

            Console.WriteLine("Enter  Operation (+,-,*,/):");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter 1st number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter @nd Number:");
            number2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{number1} + {number2} = {number2 + number2}");
                    break;

                case '-':
                    Console.WriteLine($"{number1} - {number2} = {number2 - number2}");
                    break;

                case '*':
                    Console.WriteLine($"{number1} * {number2} = {number2 * number2}");
                    break;

                case '/':
                    Console.WriteLine($"{number1} / {number2} = {number2 / number2}");
                    break;


            }*/



            //Series with For Loop:
            /*
            Console.WriteLine("enter the starting number:");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ending number:");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);

*/
            //Factorial Number using Loop:
            /*
            Console.WriteLine("Enter a number to count Fact number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                //shamim- asif
                fact = fact * i;   //Ekhane kintu 1 hobe na, i gun hobe!!!

            }
            Console.WriteLine($"Factorial({number}) = {fact}");
            */
        }
    }

}


