using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoForWebApiLecute.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public string Description { get; set; }
    }
}