namespace Module2HW1
{
    class Result
    {
        public bool Status { get; private set; }

        public string Message { get; private set; }
        public Result(bool Status, string Message = "")
        {
            this.Status = Status;
            this.Message = Message;
        }
    }
}
