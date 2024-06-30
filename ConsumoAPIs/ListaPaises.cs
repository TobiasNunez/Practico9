

namespace ConsumoAPIs
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    internal class ListaPaises
    {
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public long? Success { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]

        public string Error { get; set; }



        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public List<Pais> listaPaises { get; set; }

    }

    public class Pais
    {
        [JsonProperty("country_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryKey { get; set; }

        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]

        public string Message { get; set; }


        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; set; }

        [JsonProperty("country_iso2")]
        public string CountryIso2 { get; set; }

        [JsonProperty("country_logo", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CountryLogo { get; set; }
    }
}
