using System;
using System.Threading;

namespace Module2HW1
{
    static class Starter
    {
        public static void Run()
        {
            int i = 0;
            Random rand = new Random();
            while(i < 100)
            {
                Result result = default;
                switch(rand.Next(1, 4))
                {
                    case 1:
                        result = Actions.StartLogic();
                        break;
                    case 2:
                        result = Actions.SkipLogic();
                        break;
                    case 3:
                        result = Actions.BrokeLogic();
                        break;
                }
                if(result.Status == false)
                {
                    Logger.Instance.CreateLog(LogType.Error, $"Log failed by a reason: {result.Message}");
                }
                Thread.Sleep(30);
                i++;
            }
            Logger.Instance.SaveLogs();
        }
    }
}
