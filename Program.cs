//Завдання 1: Створіть клас «П'єса», який має зберігати таку інформацію:
// назва п'єси;  П.І.Б.автора;  жанр;  рік.
//Реалізуйте у класі методи та властивості, необхідні для функціонування класу.
//Додайте до класу деструктор.
//Напишіть код для тестування функціональності класу.
//Напишіть код для деструктора.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Play play = new Play("Назва п'єси", "Автор п'єси", "Жанр п'єси", "Рік написання п'єси");
            Console.WriteLine($"П'єса: {play.NamePlay} {play.FullNameAuthor} {play.Genre} {play.Year}");
            Console.ReadLine();
        }            
    }
}
