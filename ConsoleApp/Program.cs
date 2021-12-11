using ModelLib.DataObjects;
using ModelLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfControlLibrary.ViewModels;
using WpfControlLibrary.Views;


namespace ConsoleApp
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /* 
             * Есть консольное приложение, которое обрабатывает информацию по заданным алгоритмам.
             * 
             * Но периодически случаются ситуации, в которых нужно принять уникальное решение, на которые у программы нет прав.
             * И чтобы пользователь внёс корректировки и подтвердил дальнейшее выполнение программы (консольного приложения).
             * 
             * В зависимости от информации, нужно вызывать диалоговое окно для правки пользователем.
             */


            /*
             * Небоьльшое отступление.
             * 
             * Статический локатор использовать нельзя, так как это приложение запускается в Zenno мать его Poster.
             * Пока что нужно работать именно с ним. ТО ЕСТЬ БЕЗ СТАТИКИ. Статику использовать только там, где действительно статика для всех одна.
             * 
             * ZP использует приложения как своего рода ветки.
             * То есть если два приложения будут использовать одно статическое поле, то оно будет одним для всех, 
             * так как все библиотеки и проекты внутри это ОДНА большая программа под названием ZennoPoster.
             * 
             * P.S. На формуме название ZennoPoster опущу, чтобы меньше людей думали что с помощью него можно быстрее стартонуть в разработке.
             * Оно то быстрее, но в корне ломает понимание кода, так как у них куча ограничений.
             */




            /*
            Сами окна только компонуют другие вьюхи, так как окон будет несколько, а содержимое часто будет повторяться.
            Как я понимаю в MVVM это так и должно быть.
             */


            bool isFirst = true;

            if (isFirst)
            {
                // Условие запуска первого окна
                ClosingCourse closingCourse = GetAfterManyWork1();


                // На выходе после запуска окна, объект closingCourse должен быть изменён.
                var first = new FirstWindow(closingCourse);
                first.ShowDialog();


                // ???
                // Или же нужно создавать Locator и передавать в него объект, а внутри локатора запускать окно?
                //new LocatorDynamicFirst(closingCourse).Start();
            }
            else
            {
                CreateCourse createCourse = GetAfterManyWork2();

                var second = new SecondWindow(createCourse);
                second.ShowDialog();
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static ClosingCourse GetAfterManyWork1()
        {
            return new ClosingCourse
            {
                OrderId = 5,
                OrderName = "Приказ №5",
                DateTimeOrder = DateTime.Now,

                University = new University { Id = 1, Name = "МГИМО" },

                Courses = new List<Course>()
                {
                    new Course { Id = 1, Name = "Веб Дизайн 162" },
                    new Course { Id = 2, Name = "Вёрстка 121" },
                    new Course { Id = 3, Name = "WPF 35" },
                    new Course { Id = 4, Name = "C# 51" },
                    new Course { Id = 5, Name = "Химия 412" },
                },
            };
        }

        private static CreateCourse GetAfterManyWork2()
        {
            return new CreateCourse
            {
                OrderId = 10,
                OrderName = "Постановление №10",
                DateTimeOrder = DateTime.Now,

                Course = new Course { Id = 3, Name = "WPF 41" },

                Universities = new List<University>
                {
                    new University { Id = 1, Name = "МГИМО" },
                    new University { Id = 3, Name = "РАН" },
                    new University { Id = 5, Name = "МГУ" },
                    new University { Id = 6, Name = "МГТУ" },
                }
            };
        }
    }
}
