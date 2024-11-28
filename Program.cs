// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("h");
Console.WriteLine("Enter a number to count Fact number: ");
int number = Convert.ToInt32(Console.ReadLine());

int fact = 1;
for (int i = 1; i <= number; i++)
{
    //shamim- asif
    fact = fact * i;   //Ekhane kintu 1 hobe na, i gun hobe!!!

}
Console.WriteLine($"Factorial({number}) = {fact}");
