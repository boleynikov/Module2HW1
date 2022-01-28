namespace Module2HW1
{
    static class Actions
    {
        public static Result StartLogic()
        {
            string str = "Start Method: StartLogic";
            Logger.Instance.CreateLog(LogType.Info, str);
            return new Result(Status: true);
        }
        public static Result SkipLogic()
        {
            string str = "Skipped logic in method: SkipLogic";
            Logger.Instance.CreateLog(LogType.Warning, str);
            return new Result(Status: true);
        }
        public static Result BrokeLogic()
        {
            string str = "I broke a logic";
            Logger.Instance.CreateLog(LogType.Error, str);
            return new Result(Status: false, Message: "I broke a logic");
        }
    }
}
