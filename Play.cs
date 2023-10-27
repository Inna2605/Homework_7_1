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
using System.Threading;
using System.Threading.Tasks;

namespace Homework_7_1
{
    internal class Play
    {
        public string NamePlay;
        public string FullNameAuthor;
        public string Genre;
        public string Year;
        public Play(string N, string A, string G, string Y)
        {
            NamePlay = N;
            FullNameAuthor = A;
            Genre = G;
            Year = Y;
        }
        ~Play()
        {
            Console.WriteLine("Відпрацювання фіналізатора.");
            Thread.Sleep(60000);//Затримка часу спрацювання фіналізатора
        }
    }
}
