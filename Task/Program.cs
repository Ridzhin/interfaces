
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Task;
namespace InterfaceTask 
{ 
class Program
{ 
    static ILogger Logger { get; set; }  //Логгер из скринкаста

    static void Main()
    { 

        Logger = new Logger();
       
        var worker1 = new Worker1(Logger);
        worker1.Work();

        Console.ReadKey();
        
    } 
}

public interface ILogger
{
    void Event(string messege);
    void Error(string messege);
}

public class Logger : ILogger 
{
    public void Error(string messege)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(messege);
    }

    public void Event(string messege)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(messege);

    }
    public interface IWorker
    {
        void Work();
    }
}
}