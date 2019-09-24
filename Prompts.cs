namespace STO_Event_Calendar
{
    public readonly struct Prompts
    {
        public string EndDate { get; }
        public string Reset { get; }
        public string Needed { get; }
        public string Tokens { get; }
        public string Daily { get; }

        public Prompts(string ED, string R, string N, string T, string D)
        {
            EndDate = ED;
            Reset = R;
            Needed = N;
            Tokens = T;
            Daily = D;
        }
    }

    public readonly struct ExceptionMsgs
    {
        public string EndDate { get; }
        public string Reset { get; }
        public string Needed { get; }
        public string Tokens { get; }
        public string Daily { get; }

        public ExceptionMsgs(string ED, string R, string N, string T, string D)
        {
            EndDate = ED;
            Reset = R;
            Needed = N;
            Tokens = T;
            Daily = D;
        }
    }
}
