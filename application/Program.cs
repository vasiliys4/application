using application;
using application.model;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Console;



public class Program
{
    private const int Wight = 30;
    private const int Hight = 20;

    public static void Main()
    {
        SetWindowSize(Wight, Hight);
        SetBufferSize(Wight, Hight);

        Title = "ЗАДАЧНИК";

        Writing writing = new Writing();

        var tmp = true;
        while (tmp)
        {
            Console.WriteLine("1. Добавить запись.");
            Console.WriteLine("2. Показать запись.");
            Console.WriteLine("3. Заменить запись");
            Console.WriteLine("4. Удалить запись.");
            Console.WriteLine("5. Выход.");
            var i = Console.ReadLine();
            switch(i)
            {
                case "1":
                    Console.Clear();
                    writing.WriteName();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Writing.ShowAll();
                    Console.ReadKey();
                    Console.Clear();                    
                    break;
                case "3":
                    Console.Clear();
                    writing.RedactorTask();
                    break;
                case "4":
                    Console.Clear();
                    writing.DeliteTask();
                    Console.Clear();
                    break;
                case "5":
                    tmp = false;
                    break;
                default:
                    break;
            }
        }
    }
}
