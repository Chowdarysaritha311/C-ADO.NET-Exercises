using System;
using System.Diagnostics;
using System.IO;

class Logger
{
    public Logger()
    {
        Trace.Listeners.Clear();
        Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
        Trace.Listeners.Add(new TextWriterTraceListener("log.txt"));
        Trace.AutoFlush = true;
    }

    public void Log(string message)
    {
        Trace.WriteLine($"{DateTime.Now}: {message}");
    }
}

class Program
{
    static void Main()
    {
        Logger logger = new Logger();
        logger.Log("Application started");
        logger.Log("Performing some operations...");
        logger.Log("Application ended");
    }
}
