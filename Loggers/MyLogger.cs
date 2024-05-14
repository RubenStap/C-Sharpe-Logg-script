using System;

namespace Loggers
{
    public class MyLogger
    {
        public string Origin { get; set; }

        public MyLogger(string origin)
        {
            if (string.IsNullOrWhiteSpace(origin))
            {
                throw new ArgumentException("Origin cannot be null or empty.");
            }
            Origin = origin;
        }

        public void Log(string level, string message)
        {
            string print = LogWithTime(level, message);
            Console.WriteLine(print);
        }

        public void Warning(string message)
        {
            string print = LogWithTime("Warning", message);
            Console.WriteLine(print);
        }

        public void Error(string message)
        {
            string print = LogWithTime("Error", message);
            Console.WriteLine(print);
        }

        public void Info(string message)
        {
            string print = LogWithTime("Info", message);
            Console.WriteLine(print);
        }

        public void Debug(string message)
        {
            string print = LogWithTime("Debug", message);
            Console.WriteLine(print);
        }

        private string LogWithTime(string level, string message)
        {
            string time = DateTime.Now.ToString("HH:mm:ss tt") + " " + Origin + " " + level + ":" + message;
            return time;
        }
    }
}