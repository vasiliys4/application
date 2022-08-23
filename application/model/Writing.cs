using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace application.model
{
    internal class Writing
    {
        private static List<Recordings> TaskList = new List<Recordings>();

        /// <summary>
        /// выводим на экран задачи
        /// </summary>
        public static void ShowAll()
        {
            Console.WriteLine($"название      дата и время      описание");
            for(var i = 0; i < TaskList.Count; i++)
            {
                Console.WriteLine($"{i + 1} {TaskList[i].Name} {TaskList[i].CreationDate} {TaskList[i].Text}");
            }
        }

        /// <summary>
        /// ввод с консоли название и описание задачи
        /// </summary>
        public void WriteName()
        {
            Recordings recordings = new Recordings();
            Console.WriteLine("Введите название: ");
            recordings.Name = Console.ReadLine();
            Console.WriteLine("Введите описание: ");
            recordings.Text = Console.ReadLine();
            TaskList.Add(recordings);
        }

        /// <summary>
        /// удаление нужной задачи
        /// </summary>
        public void DeliteTask()
        {
            Console.WriteLine($"Выберите запись:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < TaskList.Count; i++)
            {
                i = number - 1;
                if (i > TaskList.Count)
                {
                    DeliteTask();
                }
                else if (i < 0)
                {
                    DeliteTask();

                }
                else
                {
                    TaskList.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// замена задачи нан новую
        /// </summary>
        public void RedactorTask()
        {
            Console.WriteLine($"Выберите запись:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < TaskList.Count; i++)
            {
                i = number - 1;
                if (i > TaskList.Count)
                {
                    RedactorTask();
                }
                else if (i < 0)
                {
                    RedactorTask();

                }
                else
                {
                    TaskList.RemoveAt(i);
                    Recordings recordings = new Recordings();
                    Console.WriteLine("Введите название: ");
                    recordings.Name = Console.ReadLine();
                    Console.WriteLine("Введите описание: ");
                    recordings.Text = Console.ReadLine();
                    TaskList.Insert(i, recordings);
                    Console.Clear();
                    break;
                }
            }
        }

    }
}
