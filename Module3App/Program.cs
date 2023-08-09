using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Это финальная практика модуля. Анкета");
        Console.Write("Как вас зовут? ");
        var name = Console.ReadLine();
        Console.Write("Сколько вам лет? ");
        var age = byte.Parse(Console.ReadLine());
        Console.Write("Назовите свою дату рождения ");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Спасибо за ваши ответы. Теперь мы знаем, что вас зовут {0}, " +
            "вам {1} лет, а ваша дата рождения {2}", name, age, birthdate);



    }
}
enum DaysOfWeek : byte
{
    Sunday,
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3
}
