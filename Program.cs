using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter your name:");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, " + userName + "!");

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You are " + age + " years old.");
    }
}