using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api
{
    [JsonObject]
    public class LogEntry
    {
        [JsonProperty("Level")] public int Level { get; set; }
        [JsonProperty("Msg")] public string Msg { get; set; }
    }
}
