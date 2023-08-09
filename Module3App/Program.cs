using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string MyName = "Nikita";
        byte MyAge = 27;
        bool HaveIPet = true;
        double MyShoeSize = 43;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("My age " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIPet);
        Console.WriteLine("My shoe size is " + MyShoeSize);

        double result = 10 % 3;
        Console.WriteLine(result);

        Console.Write("Enter your name ");
        string name = Console.ReadLine();
        Console.Write("Enter your age ");
        byte age = checked((byte) int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1}", name, age);
        Console.Write("What is your favourite day of week? ");
        DaysOfWeek day = (DaysOfWeek) byte.Parse(Console.ReadLine());
        Console.WriteLine("Your favourite day is {0}", day);
    }
}
enum DaysOfWeek : byte
{
    Sunday,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3
}
