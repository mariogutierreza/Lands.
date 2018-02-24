﻿

namespace Lands.Models
{
    using Newtonsoft.Json;

    public class Lenguage
    {
        [JsonProperty(PropertyName = "iso639_1")]
        public string Iso6391 { get; set; }

        [JsonProperty(PropertyName = "iso6392")]
        public string Iso6392 { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "nativeName")]
        public string NativeName { get; set; }
    }
}
