using System;
using System.IO;
using System.Globalization;
using System.Resources;
using Newtonsoft.Json;

namespace STOEventCalendar
{
    class JSON
    {
        private readonly string JSONOut;
        private JsonInfo? JSONInfo;
        public ResourceManager Rm { get; }

        protected struct JsonInfo
        {
            public uint ProgressLimit { get; set; }
            public uint ProgressRequired { get; set; }
            public uint BuyoutZen { get; set; }
            public uint BuyoutCost { get; set; }
            public uint BuyoutDiscount { get; set; }
            public uint DaysLeft { get; set; }
            public uint DaysNeeded { get; set; }
            public uint DaysRequired { get; set; }
        }
        public JSON(uint pl, uint pr, uint bz, uint bc, uint bd, uint dl, uint dn, uint dr)
        {
            JSONInfo = new JsonInfo
            {
                ProgressLimit = pl,
                ProgressRequired = pr,
                BuyoutZen = bz,
                BuyoutCost = bc,
                BuyoutDiscount = bd,
                DaysLeft = dl,
                DaysNeeded = dn,
                DaysRequired = dr
            };
            JSONOut = JsonConvert.SerializeObject(JSONInfo, Formatting.Indented);
            Rm = new ResourceManager("JSONStrings", typeof(JSON).Assembly);
        }
        
        private CultureInfo GetEnUs()
        {
            return new CultureInfo("en-US");
        }

        public void PrintJson()
        {
            Console.WriteLine(Rm.GetString("Header", GetEnUs()));
            Console.WriteLine(JSONOut);
        }
        public void WriteJson(string OutPath)
        {
            switch (JSONInfo) 
            { 
                case null:
                    throw new ArgumentNullException(Rm.GetString("ExceptWriteJSON", GetEnUs()));
                default:
                    File.WriteAllText(OutPath, JsonConvert.SerializeObject(JSONOut, Formatting.Indented));
                    break;
            }
        }
    }
}
