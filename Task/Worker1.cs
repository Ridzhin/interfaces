using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InterfaceTask;
using static InterfaceTask.Logger;

namespace Task
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        { 
            Logger = logger;
        }

        public void Work()   //калькулятор с конструкцией try/catch
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;    //cообщение синее
                    Console.WriteLine("Введите х");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите y");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // если ошибка красное
                    Console.WriteLine("Ошибка ввода");
                   
                }
            }
        }

    }
}
