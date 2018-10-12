using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAQ
{
    public class Pollution
    {
        [Key]
        public int Id { get; set; }
        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdate { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        public string City { get; set; }

        public string Location { get; set; }

        public string Country { get; set; }



    }
}
