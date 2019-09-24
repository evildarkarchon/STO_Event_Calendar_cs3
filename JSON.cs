using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace STO_Event_Calendar
{
    class JSON
    {
        string JSONOut;
        JsonInfo? JSONInfo;
        protected struct JsonInfo
        {
            public uint ProgressLimit { get; set; }
            public uint ProgressRequired { get; set; }
            public uint BuyoutZen { get; set; }
            public uint BuyoutCost { get; set; }
            public uint BuyoutDiscount { get; set; }
            public uint DaysLeft { get; set; }
            public uint DaysNeeded { get; set; }
        }
        public JSON(uint pl, uint pr, uint bz, uint bc, uint bd, uint dl, uint dn)
        {
            JSONInfo = new JsonInfo
            {
                ProgressLimit = pl,
                ProgressRequired = pr,
                BuyoutZen = bz,
                BuyoutCost = bc,
                BuyoutDiscount = bd,
                DaysLeft = dl,
                DaysNeeded = dn
            };
            JSONOut = JsonConvert.SerializeObject(JSONInfo, Formatting.Indented);
        }
        public void PrintJson()
        {
            Console.WriteLine("Here's the raw data (in JSON form):");
            Console.WriteLine(JSONOut);
        }
        public void WriteJson(string OutPath)
        {
            switch (JSONInfo) 
            { 
                case null:
                    throw new ArgumentNullException("Somehow WriteJSON got called while the JSONInfo variable was null.");
                default:
                    File.WriteAllText(OutPath, JsonConvert.SerializeObject(JSONOut, Formatting.Indented));
                    break;
            }
        }
    }
}
