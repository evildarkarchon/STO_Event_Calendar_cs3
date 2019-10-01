using System.IO;
using CommandLine;

namespace STOEventCalendar
{
    public class Options
    {
        [Option('l', "progress-limit", HelpText = "Amount of tokens you get per reset.")]
        public uint ProgressLimit { get; set; }

        [Option('n', "progress-needed", HelpText = "Amount of tokens needed to complete the project.")]
        public uint ProgressNeeded { get; set; }

        [Option('c', "current-progress", HelpText = "Amount of tokens you've already claimed")]
        public uint CurrentProgress { get; set; }

        [Option('e', "end-date", HelpText = "Date that the event ends.")]
        public string EndDate { get; set; }

        [Option('r', "reset", HelpText = "Amount of time, in hours, until the progress limit reset")]
        public float Reset { get; set; }

        [Option("write-json", HelpText = "Save the raw data as a JSON file.")]
        public bool WriteJson { get; set; }

        [Option("json-file", HelpText = "Path where the JSON file will be saved (defaults to STO_Event_Calculator.json in the current directory)")]
        public string JsonPath { get; set; } = @$"{Directory.GetCurrentDirectory()}\STO_Event_Calculator.json";

        [Option('q', "quiet", HelpText = "Suppress all the pretty text output (should be used with --json and/or --print-json)")]
        public bool Quiet { get; set; }

        [Option("print-json", HelpText = "Print the raw data as json to the console.")]
        public bool PrintJSON { get; set; }
    }
}

