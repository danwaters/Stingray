using System;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;

namespace Stingray
{
    public class Car
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [Version]
        public string Version { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public string Trim { get; set; }
    }
}
