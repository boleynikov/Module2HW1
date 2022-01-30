using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Module2HW1
{
    public class Logger
    {
        private static Logger instance = null;
        private static readonly object padlock = new object();

        private static readonly List<Log> LogList = new List<Log>();
        Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void CreateLog(LogType logType, string logMessage)
        {
            Log log = new Log(DateTime.Now, logType, logMessage);
            LogList.Add(log);
            Console.WriteLine(log.ToString());
        }
        public void SaveLogs()
        {
            StringBuilder str = new StringBuilder(string.Empty);
            for (int i = 0; i < LogList.Count; i++)
            {
                str.AppendLine(LogList[i].ToString());
            }
            File.WriteAllText("log.txt", str.ToString());
        }
    }
}
