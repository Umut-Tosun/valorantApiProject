using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace valorantProject.Models
{
    public class Datum
    {
        public string uuid { get; set; }
        public string assetObjectName { get; set; }
        public List<Tier> tiers { get; set; }
        public string assetPath { get; set; }
    }
}