
using System.Collections;
using System.Collections.Generic;

namespace RA.Enums
{
    public class LoadValueTypes  //: Enumeration<LoadValueTypes, string>
    {
        public static readonly LoadValueTypes TotalCall = new LoadValueTypes("Total-Call", "Total Call");
        public static readonly LoadValueTypes TotalSucceeded = new LoadValueTypes("Total-Succeeded", "Total Succeeded");
        public static readonly LoadValueTypes TotalLost = new LoadValueTypes("Total-Lost", "Total Lost");
        public static readonly LoadValueTypes AverageTTLMs = new LoadValueTypes("Average-TTL-Ms", "Average TTL Ms");
        public static readonly LoadValueTypes MaximumTTLMs = new LoadValueTypes("Maximum-TTL-Ms", "Maximum TTL Ms");
        public static readonly LoadValueTypes MinimumTTLMs = new LoadValueTypes("Minimum-TTL-Ms", "Minimum TTL Ms");

        public LoadValueTypes(string value, string displayName) //: base(value, displayName)
        {
            Value = value;
            DisplayName = displayName;
        }

        public static IEnumerable<LoadValueTypes> All => new List<LoadValueTypes>
        {
            TotalCall,
            TotalSucceeded,
            TotalLost,
            AverageTTLMs,
            MaximumTTLMs,
            MinimumTTLMs
        };

        public string Value { get; }

        public string DisplayName { get; }
    }
}